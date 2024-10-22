import { Component } from '@angular/core';
import { CadastroFormComponent } from "../../Components/cadastro-form/cadastro-form.component";

@Component({
  selector: 'app-cadastro-page',
  standalone: true,
  imports: [CadastroFormComponent],
  templateUrl: './cadastro-page.component.html',
  styleUrl: './cadastro-page.component.css'
})
export class CadastroPageComponent {

}
