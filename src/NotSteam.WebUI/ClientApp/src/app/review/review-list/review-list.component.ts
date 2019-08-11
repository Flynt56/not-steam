import { Component, OnInit } from '@angular/core';
import { ReviewService } from '../review.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';

@Component({
  selector: 'app-review-list',
  templateUrl: './review-list.component.html',
  styleUrls: ['./review-list.component.scss']
})
export class ReviewListComponent implements OnInit {

  constructor(
    private reviewService: ReviewService,
    private toastr: ToastrService,
    private router: Router,
    private spinner: SpinnerService
  ) { }

  private reviews = [];

  ngOnInit() {
    this.getAllReviews();
  }

  getAllReviews() {
    this.reviewService.getAll().subscribe((response: any) => {
      this.reviews = response;
    });
  }

  onDelete(userId, gameId) {
    if (confirm('Jeste li sigurni?')) {
      this.reviewService.deleteOne(userId, gameId).subscribe(result => {
        this.getAllReviews();
        this.toastr.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['reviews/new']);
  }

  onEdit(userId, gameId) {
    this.spinner.show();
    this.router.navigate(['reviews', userId, gameId]);
  }
}
