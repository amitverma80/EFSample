import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { person } from 'src/app/model/person.model';

@Injectable({
  providedIn: 'root',
})
export class PersonService {
  constructor(private http: HttpClient) {}

  getPersons(): Observable<person[]> {
    return this.http.get<person[]>('https://localhost:7007/api/People/GetAll');
  }
}
