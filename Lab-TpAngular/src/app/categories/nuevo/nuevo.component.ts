import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Categories } from '../../modelo/categories';
import { ServicioService } from '../../servicio/servicio.service';
import { FormControl, FormBuilder, FormGroup, Validators, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-nuevo',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.scss']
})
export class NuevoComponent implements OnInit {
  
  constructor(private activeRoute:ActivatedRoute, private ruta:Router, private api:ServicioService, private fb:FormBuilder) { }
  
  categoria:Categories;
  nuevaCategoria:FormGroup;

  get categoryNameCtrl(): AbstractControl {
    return this.nuevaCategoria.get('CategoryName');
  }

  get descriptionCtrl(): AbstractControl {
    return this.nuevaCategoria.get('Description');
  }

  ngOnInit(): void {
    this.nuevaCategoria = this.fb.group({
      CategoryName : ['', [Validators.required, Validators.minLength(3), Validators.maxLength(15)]],
      Description : ['', [Validators.required, Validators.minLength(5), Validators.maxLength(50)]]
    });
  }

  postForm(form:Categories){
    this.api.post(form).subscribe(data =>{
        console.log(data);

        if(this.nuevaCategoria.valid){
          this.api.showSucces('Categoria Agregada', 'Hecho');
          this.categoryNameCtrl.setValue('');
          this.descriptionCtrl.setValue('');
        }
    });
  }

  lista(){
    this.ruta.navigate(['lista']);
  }
}
