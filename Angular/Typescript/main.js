var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Account = /** @class */ (function () {
    function Account() {
    }
    Account.prototype.debitAmount = function () { };
    Account.prototype.creditAmount = function () { };
    Account.prototype.getBalance = function () { return this.Balance; };
    return Account;
}());
var Saving_Accout = /** @class */ (function (_super) {
    __extends(Saving_Accout, _super);
    function Saving_Accout() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Saving_Accout.prototype.addCustomer = function () {
        throw new Error("Method not implemented.");
    };
    Saving_Accout.prototype.removeCustomer = function () {
        throw new Error("Method not implemented.");
    };
    return Saving_Accout;
}(Account));
var Current_Acount = /** @class */ (function (_super) {
    __extends(Current_Acount, _super);
    function Current_Acount() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Current_Acount.prototype.addCustomer = function () {
        throw new Error("Method not implemented.");
    };
    Current_Acount.prototype.removeCustomer = function () {
        throw new Error("Method not implemented.");
    };
    return Current_Acount;
}(Account));
