import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-api-key',
  templateUrl: './api-key.component.html',
  styleUrls: ['./api-key.component.css']
})
export class ApiKeyComponent {

  apiKey: string ='';

  constructor(private router: Router) { }

  submitApiKey(){
    try{
      if(this.apiKey.trim()){
        localStorage.setItem('nytimesApiKey',this.apiKey);
        console.log('API Key submitted successfully.');
        this.router.navigate(['/view-data']);
      }else{
        console.error('API key submission failed: API key is empty.');
        alert('API Key is required!');
      }
    }catch(error){
      console.error('An unexpected error occured while submitting API key:', error);
      alert('An unexpected error occured. please try again.');
    }
  }

}
