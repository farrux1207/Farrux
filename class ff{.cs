#include <iostream>
#include <string>

using namespace std;

class Businesssaid {
public:
  string Biznesman ;
  
  void inputBusinesssaid(){
  cout << "Çäðàñòâóéòå ÷åì ìîãó ïîìî÷ü \n";
  cin >> Biznesman;
   }
};
class Patient {
public:
    double age;
     string surname  ;
    string name;
    

    void  inputPatient() {
      cout << "ðàáî÷è : ";
        cin >> name;
        cout << "âîçðàñò: ";
        cin >> age;
        cout << "ôàìèëèÿ: ";
        cin >>surname ;
        
         
    }
};
class City {
public:
    string cityName;

    void inputCity() {
        cout << "Ââåäèòå ãîðîä : ";
        cin >> cityName;
    }
};

class Business {
public:
    string Businessname ;

    void inputBusiness() {
        cout << "Íàçâàíèe ñåíòð: ";
        cin >> Businessname;
    }
};
class Number {
public:
    string workerNumber;

    void inputNumber() {
        cout << "íîìåð òåëåôîíà: ";
        cin >>workerNumber;
    }
};
class BiznesmanSpecialization {
public:
    string specialization;

    void inputBiznesmanSpecialization () {
        cout << "Ñïåöèàëüíîñòü biznesman: ";
        cin >>  specialization;
    }
};
class DayBooking {
public:
    public:
  string Date;
  int Monday;
  
  void inputDayBooking(){
    cout << "êîãäà ìû ìîæåì âñòðåòèòüñÿ"<<endl;
    cin >> Date;
  }
};
class BiznesmanAppointment {
public:
    string  biznesmanName;
    double appointmentTime;
     
    void inputBiznesmanAppointment () {
        cout << "èìÿ áèçíåñìåí: ";
        cin >> biznesmanName;
        cout << " À â êàêîå âðåìÿ âàñ çàïèñàòü? :";
    cin >> appointmentTime;
        if(appointmentTime==12){
        cout<<"Ó íàñ îáåä âûáèðèòå äðóãîå âðåìÿ";
    }
    else{
      cout<<"õîðîøî\n";
    }
    }
};
  class OnlineWork{
    public:
      string saidName;
      string Name;
      void inputOnlineWork(){
        cout<<"\nÂâåäèòå íàçâàíèÿ ñàéò:";
        cin>> saidName;
        cout<<"Ââåäèòå íàçâàíèå èíôîðìàöèÿ:";
        cin>>Name;
      }
  };


int main() {
  setlocale(LC_ALL, "Russian");
    Businesssaid mybusinesssaid;
    mybusinesssaid.inputBusinesssaid();

   Patient patient;
    patient.inputPatient();
    
    City city;
    city.inputCity();

    Business business;
    business.inputBusiness();
    
    Number number;
    number.inputNumber();
    
    BiznesmanSpecialization specialization ;
    specialization.inputBiznesmanSpecialization ();
    
    DayBooking  Day;
    Day.inputDayBooking();
  
  BiznesmanAppointment biznesman;
    biznesman.inputBiznesmanAppointment ();

cout << "Âû çàðåãèñòðèðîâàëèñü!Åñëè õîòèòå,ìîæåòå âîñïîëüçîâàòüñÿ èíòåðíåò-ññûëêîé" << endl;

  OnlineWork online ;
  online.inputOnlineWork();
  
  cout<<"Áîëüøîå ñïàñèáî çà èñïîëüçîâàíèå íàøåâî ñàéòà!";
    return 0;
}