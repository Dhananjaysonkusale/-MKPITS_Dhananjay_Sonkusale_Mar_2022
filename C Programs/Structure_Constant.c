#include<stdio.h>
#include<conio.h>

struct student
{
	int id;
	char name[20];
	
};

void main()
{
	struct student s1={ 123 ,"dhan"	}; //structure Constant
	
	printf("Student Id = %d  \n",s1.id);
	printf("Student Name = %s \n",s1.name);
}
