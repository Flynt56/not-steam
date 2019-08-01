import { Component, OnInit } from '@angular/core';
import { ReviewService } from '../review.service';

@Component({
  selector: 'app-review-list',
  templateUrl: './review-list.component.html',
  styleUrls: ['./review-list.component.scss']
})
export class ReviewListComponent implements OnInit {

  constructor(
    private reviewService: ReviewService
  ) { }

  private reviews = [];

  ngOnInit() {
    this.reviewService.getAll().subscribe((response: any) => {
      this.reviews = response;
    });
  }

}
