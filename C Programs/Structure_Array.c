#include<stdio.h>
#include<conio.h>

struct student
{
	int id;
	char name[20];
	
};

void main()
{
	struct student s[4];
	int i;
	for(i=0;i<4;i++)
	{
		printf("Enter Student Id : ");
		scanf("%d",&s[i].id);
		printf("Enter Student Name : ");
		scanf("%s",&s[i].name);
	}
	for(i=0;i<4;i++)
	{
		printf("Student Id = %d  \n",s[i].id);
		printf("Student Name = %s \n",s[i].name);
	}

}
