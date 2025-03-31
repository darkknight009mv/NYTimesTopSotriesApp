import { Component, OnInit } from '@angular/core';
import { TopStoriesService } from '../services/top-stories.services';

@Component({
  selector: 'app-display-grid-data',
  templateUrl: './display-grid-data.component.html',
  styleUrls: ['./display-grid-data.component.css']
})
export class DisplayGridDataComponent implements OnInit {
  stories: any[] = [];
  errorMessage: string = '';
  isLoading: boolean = true; // Track if data is loading
  popupVisible = false;
  popupImageUrl = '';

  constructor(private topStoriesService: TopStoriesService) { }

  ngOnInit(): void {
    const apiKey = localStorage.getItem('nytimesApiKey');
    if (!apiKey) {
      this.errorMessage = 'API Key not found. Please enter your API key.';
      console.error('API Key not found in localStorage.');
      this.isLoading = false; // Stop loading if no API key
    } else {
      this.fetchData(apiKey);
    }
  }

  fetchData(apiKey: string): void {
    this.isLoading = true; // Start loading when fetching data
    this.topStoriesService.getTopStories(apiKey).subscribe({
      next: (data) => {
        if (data && Array.isArray(data)) {
          this.stories = data;
          console.log('Data fetched successfully:', this.stories);
          this.isLoading = false; // Stop loading once data is fetched
        } else {
          console.error('Unexpected data format received:', data);
          this.errorMessage = 'Unexpected data format received.';
          this.isLoading = false;
        }
      },
      error: (error) => {
        console.error('Error fetching data:', error);
        this.errorMessage = error.message || 'An error occurred while fetching data.';
        this.isLoading = false; // Stop loading if there is an error
      }
    });
  }

  getImageUrl(story: any, format: string): string {
    const media = story.multimediaItems?.find((m: any) => m.format === format);
    return media ? media.url : 'assets/placeholder.jpg';
  }

  showPopup(story: any) {
    const jumboImage = this.getImageUrl(story, 'Super Jumbo');
    if (jumboImage) {
      this.popupImageUrl = jumboImage;
      this.popupVisible = true;
    }
  }
}
