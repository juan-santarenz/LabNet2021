import { Injectable } from '@angular/core';
import { Categories } from '../modelo/categories';
import { HttpClient, HttpHeaders, HttpResponse, HttpParams } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { ToastrService } from 'ngx-toastr';


@Injectable({
  providedIn: 'root'
})
export class ServicioService {
  constructor(private http:HttpClient, private toastr: ToastrService) { }

  getAll():Observable<Categories[]>{
    let lista =  environment.categories + "/Categories";

    return this.http.get<Categories[]>(lista);
  }

  getOne(id):Observable<Categories>{
    let cat = environment.categories + "/Categories/" + id;
    
    return this.http.get<Categories>(cat);
  }

  put(form:Categories):Observable<Categories>{
    let cat = environment.categories + "/Categories/" + form.CategoryID;
    
    return this.http.put<Categories>(cat, form);
  }

  delete(form:Categories):Observable<Categories>{
    let cat = environment.categories + "/Categories/" + form.CategoryID;
     
    return this.http.delete<Categories>(cat);
    
  }

  post(form:Categories):Observable<Categories>{
    let nuevaCategoria =  environment.categories + "/Categories";
    
    return this.http.post<Categories>(nuevaCategoria, form);
  }

  showSucces(texto, titulo){
    this.toastr.success(texto, titulo);
  }
  showError(texto, titulo){
    this.toastr.error(texto, titulo);
  }
}
