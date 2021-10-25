import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InicioComponent } from './inicio/inicio.component';
import { JogosComponent } from './jogos/jogos.component';

const routes: Routes = [
  { path: '', redirectTo: "Inicio" , pathMatch: 'full' },
  { path: 'Inicio', component: InicioComponent },
  { path: 'Jogos', component: JogosComponent },
  
  
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
