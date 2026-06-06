Student student1 = new Student("John Doe", "12345", "HsM0Z@example.com");

ResultCard resultCard1 = new ResultCard("R001");
resultCard1.AddScore(85);
resultCard1.AddScore(67);

student1.StudentResultCard = resultCard1;

resultCard1.AddScore(90);

student1.StudentResultCard.AddScore(75);

Console.WriteLine($"Student Name: {student1.Name}");
Console.WriteLine($"Registration Number: {student1.RegNo}");
Console.WriteLine($"Email: {student1.Email}");
Console.WriteLine($"Total Obtained Score: {student1.StudentResultCard.TotalObtainedScore}");    
Console.WriteLine($"Is Passed: {student1.IsPassed()}");





