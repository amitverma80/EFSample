import { Component, OnInit } from '@angular/core';
import { person } from 'src/app/model/person.model';
import { MatTableDataSource } from '@angular/material/table';
import { PersonService } from 'src/app/core/services/person/person.service';
/*
const personData: person[] = [
  {
    id: 1,
    firstName: 'A',
    lastName: 'Aa',
    email: 'a@a.com',
  },
  {
    id: 2,
    firstName: 'B',
    lastName: 'Bb',
    email: 'b@b.com',
  },
  {
    id: 3,
    firstName: 'C',
    lastName: 'Cc',
    email: 'c@c.com',
  },
];
*/
@Component({
  selector: 'app-persons-list',
  templateUrl: './persons-list.component.html',
  styleUrls: ['./persons-list.component.scss'],
})
export class PersonsListComponent implements OnInit {
  constructor(private personService: PersonService) {}

  displayedColumns = ['personId', 'name', 'age', 'address', 'email'];
  dataSource = new MatTableDataSource<person>();

  ngOnInit(): void {
    //this.dataSource = new MatTableDataSource<person>(personData);
    this.getPerson();
  }
  ngAfterViewInit() {
    // this.dataSource.sort = this.sort;
    // this.dataSource.paginator = this.paginator;
  }

  getPerson() {
    this.personService.getPersons().subscribe((data) => {
      console.log(data);
      this.dataSource.data = data;
    });
  }

  applyFilter(event: Event) {
    let filterValue = (event.target as HTMLInputElement).value;
    filterValue = filterValue.trim(); // Remove whitespace
    filterValue = filterValue.toLowerCase(); // MatTableDataSource defaults to lowercase matches
    this.dataSource.filter = filterValue;
  }
}
