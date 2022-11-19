import { Component, OnInit } from '@angular/core';
import { person } from 'src/app/model/person.model';
import { MatTableDataSource } from '@angular/material/table';

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

@Component({
  selector: 'app-persons-list',
  templateUrl: './persons-list.component.html',
  styleUrls: ['./persons-list.component.scss'],
})
export class PersonsListComponent implements OnInit {

  constructor() {}

  displayedColumns = ['id', 'firstName', 'lastName', 'email'];
  dataSource = new MatTableDataSource<person>();

  ngOnInit(): void {
    this.dataSource = new MatTableDataSource<person>(personData);
  }
  ngAfterViewInit() {
    // this.dataSource.sort = this.sort;
    // this.dataSource.paginator = this.paginator;
  }

  applyFilter(event: Event) {
    let filterValue = (event.target as HTMLInputElement).value;
    filterValue = filterValue.trim(); // Remove whitespace
    filterValue = filterValue.toLowerCase(); // MatTableDataSource defaults to lowercase matches
    this.dataSource.filter = filterValue;
  }
}
