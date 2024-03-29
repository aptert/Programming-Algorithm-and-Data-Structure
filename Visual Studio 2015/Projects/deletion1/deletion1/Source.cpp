#include <iostream>

//Nodes and lists use public data members for convenience
//This may make some software engineers froth at the mouth

class Node
{
public:
	int value; //This could really be any type
	Node* next;
	Node* prev;
	Node(int val) {
		std::cout << "Node constructr! " << val << std::endl;
		this->value = val;
		this->next = (Node*)0;
		this->prev = (Node*)0;
	}
	~Node() {
		std::cout << "Node destructor" << std::endl;
		std::cout << "I had the value " << this->value << std::endl;
	}
};
class List
{

public:
	Node* head;
	Node* tail;

	List() {
		std::cout << "List Constructor!" << std::endl;
		this->head = 0;
		this->tail = 0;
	}
	~List() {
		std::cout << "List destructor!" << std::endl;
		std::cout << "Todo: properly delete nodes..." << std::endl;
	}
	void insert(Node* n, Node* x) {
		//Not actually perfect: how do we prepend to an existing list?
		if (n != 0) {
			x->next = n->next;
			n->next = x;
			x->prev = n;
			if (x->next != 0)
				x->next->prev = x;
		}
		if (this->head == 0) {
			this->head = x;
			this->tail = x;
			x->prev = 0;
			x->next = 0;
		}
		else if (this->tail == n) {
			this->tail = x;
		}
	}

	void erase(Node* n) {


		if (n != 0 && n != this->tail && n != this->head) {
			n->next->prev = n->prev;
			n->prev->next = n->next;
		}
		
		if (this->tail == n) {
			this->tail = n->prev;
			n->prev->next = 0;
		}
		if (this->head == n) {
			this->head = n->next;
			n->next->prev = 0;
		}

		std::cout << "tail is " << std::endl;
		std::cout << this->tail->value << std::endl;
	}
	void display() {
		Node* i = this->head;
		std::cout << "List: ";
		while (i != 0) {
			std::cout << i->value << ",";
			i = i->next;
		}
		std::cout << std::endl;
	}
};

int main(int argc, char *argv[])
{
	List* l = new List();
	Node *k = new Node(4);
	l->insert(0, k);
	Node *n = new Node(6);
	l->insert(l->head, n);
	Node *m = new Node(8);
	l->insert(l->head, m);

	Node *t = new Node(10);
	l->insert(l->head, t);
	Node *p = new Node(12);
	l->insert(l->head, p);
	l->display();
	//delete l;
	std::cout << "am about to erase" << std::endl;
	l->erase(n);
	l->display();
	getchar();
	return 0;
}