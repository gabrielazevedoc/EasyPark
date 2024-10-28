import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { environment } from '../environments/environment.development';
import { Usuario } from '../Models/Usuario';
import { tap, catchError, map } from 'rxjs/operators';
import { Router } from '@angular/router';


const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})

export class UsuarioService {

  private apiUrl = `${environment.ApiUrl}/Usuario`;
  private tokenKey = 'auth_token';


  constructor(private http: HttpClient, private router: Router) { }

  cadastrar(usuario: Usuario): Observable<Usuario> {
    return this.http.post<Usuario>(`${this.apiUrl}/cadastrar`, usuario, httpOptions);
  }

  login(credentials: { email: string; senha: string }): Observable<Usuario | null> {
    return this.http.post<Usuario>(`${this.apiUrl}/login`, credentials).pipe(
      map((response) => response), // retorna diretamente o objeto `user`
      catchError((error) => {
        console.error('Login falhou:', error);
        return of(null); // retorna `null` em caso de erro
      })
    );
  }

  getUserInfo(id : number): Observable<Usuario | null> {
    const token = localStorage.getItem(this.tokenKey);
    if (token) {
      return this.http.get<Usuario>(`${this.apiUrl}/${id}`, {
        headers: { Authorization: `Bearer ${token}` },
      }).pipe(
        catchError(() => of(null)) // Retorna `null` se a requisição falhar
      );
    }
    return of(null);
  }

  isLoggedIn(): boolean {
    return !!localStorage.getItem(this.tokenKey);
  }

  logout(): void {
    localStorage.removeItem(this.tokenKey);
    this.router.navigate(['/login']);
  }

  getUsuarioById(id: number): Observable<Usuario> {
    return this.http.get<Usuario>(`${this.apiUrl}/${id}`);
  }

}
