
//Савенко Вадим Романович
// Задание со списком
#include <stdio.h>
#include <math.h>

#define T char;

typedef struct Node
{
	T data;
	struct  Node *next;
	
}Node;

typedef struct {
	Node *head;
	int size;
}Stack;

int push(Stack *st, T val)
{
	Node *temp = (Node*)malloc(sizeof(Node));
	if (temp == NULL)return 0;
	return 1;
}

int main()
{
	return 0;
}