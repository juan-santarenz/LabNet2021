import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Categories } from '../../modelo/categories';
import { ServicioService } from '../../servicio/servicio.service';
import { FormControl, FormBuilder, FormGroup, Validators, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
  styleUrls: ['./editar.component.scss']
})
export class EditarComponent implements OnInit {

  constructor(private activeRoute:ActivatedRoute, private ruta:Router, private api:ServicioService, private fb:FormBuilder) { }

  categoria:Categories;
  editarCategoria:FormGroup;

  get categoryIdCtrl(): AbstractControl {
    return this.editarCategoria.get('Description');
  }
  get categoryNameCtrl(): AbstractControl {
    return this.editarCategoria.get('CategoryName');
  }

  get descriptionCtrl(): AbstractControl {
    return this.editarCategoria.get('Description');
  }
  /* editarCategoria = new FormGroup({
    CategoryID: new FormControl ('', Validators.required),
    CategoryName : new FormControl ('', [Validators.required, Validators.minLength(3), Validators.maxLength(15)]),
    Description : new FormControl ('', [Validators.required, Validators.minLength(5), Validators.maxLength(50)])
  }) */


  ngOnInit(): void {
    this.editarCategoria = this.fb.group({
      CategoryID: ['', Validators.required],
      CategoryName : ['', [Validators.required, Validators.minLength(3), Validators.maxLength(15)]],
      Description : ['', [Validators.required, Validators.minLength(5), Validators.maxLength(50)]]
    });
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
      if(this.editarCategoria.valid){
        this.api.showSucces('Categoria Actualizada', 'Hecho');
        this.ruta.navigate(['lista']);
      }
    });
  }

  eliminar(){
    let datos:Categories = this.editarCategoria.value;
    this.api.delete(datos).subscribe(data => {
      console.log(data);
      if(this.editarCategoria.valid){
        this.api.showSucces('Categoria Eliminada', 'Hecho');
        this.ruta.navigate(['lista']);
      }
    })
  }

  lista(){
    this.ruta.navigate(['lista']);
  }

}
