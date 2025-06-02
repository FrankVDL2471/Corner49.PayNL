using System.Text.Json.Serialization;

namespace Corner49.PayNL.V3.Requests.Orders.InputMethods;

[JsonDerivedType(typeof(DirectDebitInput))]
[JsonDerivedType(typeof(IdealInput))]
[JsonDerivedType(typeof(KlarnaInput))]
[JsonDerivedType(typeof(PayByBankInput))]
[JsonDerivedType(typeof(PinInput))]
[JsonDerivedType(typeof(Przelewy27Input))]
[JsonDerivedType(typeof(SprayPayInput))]
public abstract class V3InputMethod {

}
