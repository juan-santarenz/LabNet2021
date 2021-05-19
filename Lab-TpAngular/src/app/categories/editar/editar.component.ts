import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Categories } from '../../modelo/categories';
import { ServicioService } from '../../servicio/servicio.service';
import { FormControl, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
  styleUrls: ['./editar.component.scss']
})
export class EditarComponent implements OnInit {

  constructor(private activeRoute:ActivatedRoute, private ruta:Router, private api:ServicioService) { }

  categoria:Categories;

  editarCategoria = new FormGroup({
    CategoryID: new FormControl ('', Validators.required),
    CategoryName : new FormControl ('', [Validators.required, Validators.minLength(3), Validators.maxLength(15)]),
    Description : new FormControl ('', [Validators.required, Validators.minLength(5), Validators.maxLength(50)])
  })


  ngOnInit(): void {
    let cateogiraId = this.activeRoute.snapshot.paramMap.get('id');
    this.api.getOne(cateogiraId).subscribe(data =>{
      this.categoria = data;
      this.editarCategoria.setValue({
        'CategoryID' : this.categoria.CategoryID,
        'CategoryName' : this.categoria.CategoryName,
        'Description' : this.categoria.Description
      });
      console.log(this.editarCategoria);
    });
  }

  putForm(form:Categories){
    this.api.put(form).subscribe(data =>{
      console.log(data);
    });
  }

  eliminar(){
    let datos:Categories = this.editarCategoria.value;
    this.api.delete(datos).subscribe(data => {
      console.log(data);
      this.ruta.navigate(['lista']);
    })
  }

  lista(){
    this.ruta.navigate(['lista']);
  }

}
