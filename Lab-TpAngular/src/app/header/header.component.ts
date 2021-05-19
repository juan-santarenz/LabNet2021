import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor(private ruta:Router) { }

  ngOnInit(): void {
  }

  lista(){
    this.ruta.navigate(['lista']);
  }
}
