#include <stdio.h>
#include <stdlib.h>

#define T char
#define SZ 100


typedef struct Node {
	T data;
	struct Node *next;
} Node;

typedef struct {
	Node *head;
	int size;
} Stack;

int push(Stack *st, char val) {
	Node *temp = (Node*)malloc(sizeof(Node));
	if (temp == NULL) return 0;

	temp->data = val;
	temp->next = st->head;

	st->head = temp;
	st->size++;
	return 1;
}



int main(int argc, const char** argv) {
	Stack s;
	s.size = 0;
	s.head = NULL;

	printf("%s\n", "This is linked list");

	push(&s, 'a');
	push(&s, 'b');
	push(&s, 'c');
	push(&s, 'd');
	push(&s, 'e');
	push(&s, 'f');

	return 0;
}