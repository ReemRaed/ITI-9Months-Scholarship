
class Account
{
   
    Acc_no:number;
    Balance:number;
     
    debitAmount(){}
    creditAmount(){}
    getBalance(){return this.Balance;}
}

interface IAccount
{
    Date_of_Opening:Date;
    addCustomer();
    removeCustomer();
}

class Saving_Accout extends Account implements IAccount
{
    Date_of_Opening: Date;
    addCustomer() {
        throw new Error("Method not implemented.");
    }
    removeCustomer() {
        throw new Error("Method not implemented.");
    }
    Min_Balance:number;
}
class Current_Acount extends Account implements IAccount
{
    Date_of_Opening: Date;
    addCustomer() {
        throw new Error("Method not implemented.");
    }
    removeCustomer() {
        throw new Error("Method not implemented.");
    }
    Interest_rate:number;
}


