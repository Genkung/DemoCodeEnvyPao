import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
 sumnumber:any;
 numberresual:any;
  constructor(public navCtrl: NavController,private http: HttpClient) {

  }
  
 click() {
    this.http.get<number[]>("http://node15.codenvy.io:49250/api/Consecutive/CalculateFromSum/"+this.sumnumber)
      .subscribe((data) => {
this.numberresual = data;
    console.log("Resual : " + data);
      },
        error => {
          alert("Error: " + error + "\nError message: " + error.message + "\nError result: " + error.error)
        });
  }


}
