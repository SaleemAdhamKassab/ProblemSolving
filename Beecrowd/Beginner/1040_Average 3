#include<bits/stdc++.h>
using namespace std;

int main()
{
    double first, second, third, fourth, last, sum;
    cin>>first>>second>>third>>fourth;
    sum = (first * 2 + second * 3 + third * 4 + fourth) / 10;
    cout<<fixed;
    cout<<setprecision(1)<<"Media: "<<sum<<endl;
    if (sum >= 7.0){
        cout<<"Aluno aprovado.\n";
    }
    else if (sum >= 5.0)
    {
        cout<<"Aluno em exame.\n";
        cin>>last;
       
        cout<<setprecision(1)<<"Nota do exame: "<<last<<endl;
        if (last + sum / 2.0 > 5.0){
            cout<<"Aluno aprovado.\n";
        }
        else{
            cout<<"Aluno reprovado.\n";
        }
        
        cout<<setprecision(1)<<"Media final: "<<(last + sum ) / 2.0<<endl;
    }
    else{
        cout<<"Aluno reprovado.\n";
    }
    return 0;
}
