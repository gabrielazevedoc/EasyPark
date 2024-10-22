import { Routes } from '@angular/router';
import path from 'node:path';
import { LoginPageComponent } from './Pages/login-page/login-page.component';
import { CadastroPageComponent } from './Pages/cadastro-page/cadastro-page.component';
import { ReservaPageComponent } from './Pages/reserva-page/reserva-page.component';

export const routes: Routes = [
    { path: '', redirectTo: '/reserva', pathMatch: 'full' }, 
    { path: 'login', component: LoginPageComponent }, 
    { path: 'cadastro', component: CadastroPageComponent }, 
    { path: 'reserva', component: ReservaPageComponent }
];
