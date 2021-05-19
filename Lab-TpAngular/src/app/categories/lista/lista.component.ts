import { Component, OnInit } from '@angular/core';
import { ServicioService } from '../../servicio/servicio.service';
import { Router } from '@angular/router';
import { Categories } from '../../modelo/categories'

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.scss']
})
export class ListaComponent implements OnInit {

  categories: Categories[];

  constructor(private api:ServicioService, private ruta:Router) { }

  ngOnInit(): void {
    this.api.getAll().subscribe(data => {
      this.categories = data;
    })
  }

  editar(id){
    this.ruta.navigate(['editar', id]);
  }

  nuevo(){
    this.ruta.navigate(['nuevo']);
  }

}
