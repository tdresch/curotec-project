import { HttpClient } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { JobCategoryResponse } from 'src/app/models/job-category-response.model';
import { JobCategoryService } from 'src/app/services/job-category.service';

@Component({
  selector: 'app-job-category',
  templateUrl: './job-category.component.html',
  styleUrls: ['./job-category.component.scss'],
})
export class JobCategoryComponent implements OnInit, OnDestroy {
  jobCategories: JobCategoryResponse[] = [];
  private jobCategorySubscription?: Subscription;

  constructor(private readonly jobCategoryService: JobCategoryService) {}

  ngOnInit(): void {
    this.jobCategorySubscription = this.jobCategoryService
      .getJobCategories()
      .subscribe({
        next: (response) => {
          this.jobCategories = response;
        },
        error: (error) => {
          console.error('Error getting job categories', error);
        },
      });
  }
  ngOnDestroy(): void {
    this.jobCategorySubscription?.unsubscribe();
  }
}
