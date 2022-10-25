#include <iostream>
#include <vector>

using namespace std;

int main() {
    int nOrder;
    cin >> nOrder;
    
    vector<int> stack;
    string order;
    int num;
    
    for(int i = 0; i < nOrder; i++) {
        cin >> order;
        
        if(order == "push") {
            cin >> num;
            stack.push_back(num);
        }
        else if(order == "pop") {
            if(stack.empty()) cout << -1 << '\n';
            else {
                cout << stack.back() << '\n';
                stack.pop_back();
            }
        }
        else if(order == "size") {
            cout << stack.size() << '\n';
        }
        else if(order == "empty") {
            cout << stack.empty() << '\n';
        }
        else if(order == "top") {
            if(stack.empty()) cout << -1 << '\n';
            else cout << stack.back() << '\n';
        }
    }
    
    return 0;
}