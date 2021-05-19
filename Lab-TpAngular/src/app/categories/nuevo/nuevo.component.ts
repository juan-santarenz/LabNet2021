import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Categories } from '../../modelo/categories';
import { ServicioService } from '../../servicio/servicio.service';
import { FormControl, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-nuevo',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.scss']
})
export class NuevoComponent implements OnInit {
  
  constructor(private activeRoute:ActivatedRoute, private ruta:Router, private api:ServicioService) { }
  
  categoria:Categories;
  
  nuevaCategoria = new FormGroup({
    CategoryName : new FormControl ('', [Validators.required, Validators.minLength(3), Validators.maxLength(15)]),
    Description : new FormControl ('', [Validators.required, Validators.minLength(5), Validators.maxLength(50)])
  })

  ngOnInit(): void {
  }

  postForm(form:Categories){
    this.api.post(form).subscribe(data =>{
        console.log(data);
    });
  }

  lista(){
    this.ruta.navigate(['lista']);
  }



  
}
