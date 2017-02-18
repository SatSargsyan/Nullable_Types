# Nullable Types

##Nullable types have the following characteristics:
<ul type =square>
<li><a href=https://msdn.microsoft.com/en-us/library/1t3y8s4s.aspx>Nullable types</a> represent value-type variables that can be assigned the value of null. You cannot create a nullable type based on a reference type. (Reference types already support the null value.)
<li>The syntax T? is shorthand for Nullable<T>, where T is a value type. The two forms are interchangeable.
<li>Assign a value to a nullable type just as you would for an ordinary value type, for example int? x = 10; 
<br>or double? d = 4.108.
A nullable type can also be assigned the value null: int? x = null.
<li>Use the Nullable<T>.GetValueOrDefault method to return either the assigned value, or the default value for the underlying type if the value is null, for example int j = x.GetValueOrDefault();
<li>Use the HasValue and Value read-only properties to test for null and retrieve the value, as shown in the following example: if(x.HasValue) j = x.Value;
<ul type =circle>
<li>The HasValue property returns true if the variable contains a value, or false if it is null.
<li>The Value property returns a value if one is assigned. Otherwise, a System.InvalidOperationException is thrown.
<li>The default value for HasValue is false. The Value property has no default value.
<li>You can also use the == and != operators with a nullable type, as shown in the following example: <br>if (x != null) y = x;
</ul>
<li>Use the ?? operator to assign a default value that will be applied when a nullable type whose current value is null is assigned to a non-nullable type, for example int? x = null; int y = x ?? -1;
<li>Nested nullable types are not allowed. The following line will not compile: Nullable <Nullable><int>  n;
</ul>


##Boxing Nullable Types
###Objects based on nullable types are only boxed if the object is non-null. If HasValue is false, the object reference is assigned to null instead of boxing. For example:
```C#
bool? b = null;  
object o = b;  
// Now o is null.
```
###If the object is non-null -- if HasValue is true -- then boxing occurs, but only the underlying type that the nullable object is based on is boxed. Boxing a non-null nullable value type boxes the value type itself, not the System.Nullable<T> that wraps the value type. For example:
```C#
bool? b = false;  
int? i = 44;  
object bBoxed = b; // bBoxed contains a boxed bool.  
object iBoxed = i; // iBoxed contains a boxed int.  
```
###The two boxed objects are identical to those created by boxing non-nullable types. And, just like non-nullable boxed types, they can be unboxed into nullable types, as in the following example:
```C#
bool? b2 = (bool?)bBoxed;  
int? i2 = (int?)iBoxed;  
```
##How to: Identify a Nullable Type



##Example
```C#
double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            ```
            
            ![nullable1](https://cloud.githubusercontent.com/assets/20840005/23096396/327e67d8-f635-11e6-952b-f6e9cb668b68.JPG)

