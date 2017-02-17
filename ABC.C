#include<stdio.h>
#include<conio.h>
void main()
{
	int n,m;
	clrscr();
	printf("Enter No:");
	scanf("%d",&n);
	printf("%d",n);
	m=n;
	for(int i=0;i<n;i++)
	{
		if(i%2==0)
		{
		for(int k=0;k<(m/2);k++)
		{
			printf(" ");
		}
		m=m-2;
		for(int j=0;j<=i;j++)
		{
			printf("*");
		}
		}
		printf("\n");
	}
       //	printf("%d",&m);
	for(int x=n;x>=0;x--)
	{
		if(x%2==0)
		{
			for(int k=0;k>(m/2) ;k++)
			{
				printf(" ");
			}
			m=m+2;
			for(int j=0;j<=x;j++)
			{
				printf("*");
			}
		printf("\n");
		}
	}
	getch();
}