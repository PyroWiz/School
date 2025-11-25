let students = Number(prompt("how many students?"));
let all= 0;
let avg = 0;
let divstudents = students;
while (students>0)
{
    let grades = Number(prompt("how many grades for this student?"));
    let divgrades = grades;
    let sum = 0;
    while (grades>0)
    {
       sum += Number(prompt("enter the grade"));
       grades--;
    }
    avg+= sum/divgrades;
    students--;
}
all = avg/divstudents;

alert("the average of all students is: " + all);