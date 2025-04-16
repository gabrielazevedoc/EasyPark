import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { LoginPageComponent } from './Pages/login-page/login-page.component';
import { CadastroPageComponent } from './Pages/cadastro-page/cadastro-page.component';
import { MenuComponent } from './Components/menu/menu.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, LoginPageComponent, CadastroPageComponent, MenuComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'EasyParkApp';
}
