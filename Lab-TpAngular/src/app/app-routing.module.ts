import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ListaComponent} from './categories/lista/lista.component';
import {NuevoComponent} from './categories/nuevo/nuevo.component';
import {EditarComponent} from './categories/editar/editar.component';


const routes: Routes = [
  {path: '', redirectTo: 'lista', pathMatch: 'full'},
  {path: 'lista', component: ListaComponent},
  {path: 'nuevo', component: NuevoComponent},
  {path: 'editar/:id', component: EditarComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const rutasComponents = [ListaComponent, NuevoComponent, EditarComponent]
