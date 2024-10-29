// src/app/services/usuario.service.ts
import { Injectable, Inject, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { environment } from '../environments/environment.development';
import { Usuario } from '../Models/Usuario';
import { tap, catchError, map } from 'rxjs/operators';
import { Router } from '@angular/router';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  private apiUrl = `${environment.ApiUrl}/Usuario`;

  constructor(
    private http: HttpClient,
    private router: Router,
    @Inject(PLATFORM_ID) private platformId: object // Injeta a plataforma atual
  ) {}

  cadastrar(usuario: Usuario): Observable<Usuario> {
    return this.http.post<Usuario>(`${this.apiUrl}/cadastrar`, usuario, httpOptions);
  }

  login(credentials: { email: string; senha: string }): Observable<Usuario | null> {
    return this.http.post<Usuario>(`${this.apiUrl}/login`, credentials).pipe(
      tap((response) => {
        if (isPlatformBrowser(this.platformId) && response && response.id) {
          // Apenas armazena o ID do usuário no navegador
          localStorage.setItem('loggedInUserId', response.id.toString());
        }
      }),
      catchError((error) => {
        console.error('Login falhou:', error);
        return of(null);
      })
    );
  }

  getUserInfo(id: number): Observable<Usuario | null> {
    return this.http.get<Usuario>(`${this.apiUrl}/${id}`).pipe(
      catchError((error) => {
        console.error('Falha ao obter informações do usuário:', error);
        return of(null);
      })
    );
  }

  getLoggedInUserId(): number | null {
    if (isPlatformBrowser(this.platformId)) {
      const id = localStorage.getItem('loggedInUserId');
      return id ? parseInt(id, 10) : null;
    }
    return null; // Retorna `null` se não estiver no navegador
  }

  logout(): void {
    if (isPlatformBrowser(this.platformId)) {
      localStorage.removeItem('loggedInUserId');
    }
    this.router.navigate(['/login']);
  }
}
