# wf-poll-cwe

### A WinForms Poll App for CodeWithMe Meetup Edit

----

### How to Build?
- Clone the repo
- Open the solution in Visual Studio 
- Hit the "Start" button to build the project

### Dependencies
- .NET 4.x (Built with 4.6.1)
- System.Windows.Forms 4.x ("WinForms")
- Visual Studio 2015+ (Created in VS2017)

### What's Configurable?
- In Poller.cs, try changing the names of either candidate. The names are passed to the CandidateList constructor.

### Can I view it in the Form Designer?
- Almost, but no. Two text labels are dynamically created, and these break the designer window. To get back the designer, Go to ```PollForm.Designer.cs``` and change these two lines:
    
  - ```this.CandidateOne.Text = poller.GetCandidates().CandidateOne;```
  - ```this.CandidateTwo.Text = poller.GetCandidates().CandidateTwo;```
  
  To...

  - ```this.CandidateOne.Text = "Iron Man";``` 
  - ```this.CandidateOne.Text = "Captain America";```  

These two fields control the Poll labels, but nothing else. So whenever you change the candidate names, you have to manually change these fields.

----

#### References

- Based on this tutorial: http://dotnettutorials.com/tutorials/windows-programming-in-net/winform-poll-cs/

- Special thanks to https://dotnetfiddle.net for LINQ troubleshooting