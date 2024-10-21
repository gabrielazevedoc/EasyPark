import { Routes } from '@angular/router';
import path from 'node:path';
import { LoginPageComponent } from './Pages/login-page/login-page.component';
import { CadastroPageComponent } from './Pages/cadastro-page/cadastro-page.component';

export const routes: Routes = [
    { path: '', redirectTo: '/login', pathMatch: 'full' }, // Rota padrão
    { path: 'login', component: LoginPageComponent }, // Rota para HomeComponent
    { path: 'cadastro', component: CadastroPageComponent }, // Rota para AboutComponent
];
