using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
		Action<object> print = Console.WriteLine;

	List<Student> list = new List<Student> {
		new Student() { Id = 0, Name = "ctkim", Height = 175}, // Pk 
		new Student() { Id = 1, Name = "Steve", Height = 167},
		new Student() { Id = 2, Name = "Brown", Height = 180},
		new Student() { Id = 3, Name = "Won", Height = 171},
		new Student() { Id = 4, Name = "JJ", Height = 165}
		};

	List<Score> scores = new List<Score> {
		new Score() { StudentId = 0,/*Name = "ctkim",*/ Subject="Math", Point = 70},
		new Score() { StudentId = 4,/* Name = "Steve",*/ Subject="Math", Point = 60},
		new Score() { StudentId = 3,/* Name = "Brown",*/ Subject="Math", Point = 90},
		new Score() { StudentId = 2,/* Name = "Won",*/ Subject="Math", Point = 10},
		new Score() { StudentId = 1,/* Name = "JJ",*/ Subject="Math", Point = 30},
		new Score() { StudentId = 0,/* Name = "JJ",*/ Subject="English", Point = 70},
		new Score() { StudentId = 4,/* Name = "JJ",*/ Subject="English", Point = 60},
		new Score() { StudentId = 3,/* Name = "JJ",*/ Subject="English", Point = 90},
		new Score() { StudentId = 2,/* Name = "JJ",*/ Subject="English", Point = 10},
		new Score() { StudentId = 1,/* Name = "JJ",*/ Subject="English", Point = 30}
		};

// 한과목 60이상 평균이 80이상인 학생 찾기. 쿼리로 만들기
// 이름만 출력 
// DB 쿼리 Sq?

		var ss1 = from s in list
							join score in scores on s.Id equals score.StudentId
							select new { Name = s.Name, Subject=score.Subject, Point=score.Point }; 
		print(ss1.Stringify());
		print(ss1.Count() == 10);
		print(ss1.Average(s=>s.Point) == 52);

		var ss2 = 
			from score in scores
			group score by score.Subject;

			// subjectGroup is an IGrouping<string, Score>
			//	(key, listM<Score>)

			foreach(var subjectGroup in ss2) {
				print(subjectGroup.Key);
				foreach(Score score in subjectGroup) {
					print($"		{score.Point}");
				}
			}
  }
}

public class Student {
	public int Id { get; set; }
	public string Name { get; set; }
	public int Height { get; set; }

	public override string ToString() { return Name; }
}

public class Score {
	public int StudentId { get; set; }
	public string Name { get; set; }
	public string Subject { get; set; }
	public int Point { get; set; }
}

public static class ClassExtension {
  public static string Stringify<T>(this IEnumerable<T> list) {
    return String.Join("\n", list);
  }
}