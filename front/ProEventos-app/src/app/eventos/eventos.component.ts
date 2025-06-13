import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {
  
  public eventos: any = [
    //{
    //  Tema: 'Angular e suas novidades',
    //  Local: 'São Paulo'      
    //},
   // {
    //  Tema: 'React e suas novidades',
    //  Local: 'Rio de Janeiro'
    //},
    // {
    //  Tema: 'Vue.js e suas novidades',
    //  Local: 'Belo Horizonte'
    //}
  ];    

  constructor(private http: HttpClient) { }

  ngOnInit() {
    // This method is called when the component is initialized
    // You can perform any initialization logic here
    this.getEventos()
  }

  // You can add additional methods and properties for this component as needed

  public getEventos(): void {
    // This method can be used to fetch or manipulate the eventos data
    // For now, it is just a placeholder
    console.log('Fetching eventos data...');
    //this.eventos = [
    //    {
    //      Tema: 'Angular e suas novidades',
    //      Local: 'São Paulo'      
    //    },
    //    {
    //       Tema: 'React e suas novidades',
    //      Local: 'Rio de Janeiro'
    //    },
    //    {
    //      Tema: 'Vue.js e suas novidades',
    //      Local: 'Belo Horizonte'
    //    }
    //];  
    
    this.http.get("https://localhost:5001/api/Evento").subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
  }
  

}
