/*
	Object that has getSetGen as function value,
	• this function should generate setters and getters for the properties of the caller instance
	• this object may have description property of string value if needed
	• Let any other created instance can use this function property to generate
		getters and setters for his own properties 
	• Avoid generating getters or setters for property of function value
*/

// getSetGen function
var getSetGen = function () {
  for (var key in this) {
    if (typeof this[key] !== "function") {
      (function (object, key) {
        var value = object[key];
        Object.defineProperty(object, key, {
          get: function () {
            return value;
          },
          set: function (newValue) {
            value = newValue;
          },
          enumerable: true,
          configurable: true,
        });
      })(this, key);
    }
  }
};

// Object with getSetGen
var obj = {
  id: 1,
  username: "Zain",
  address: "Cairo, Egypt",
  print: function () {
    return `ID: ${obj.id}\nUsername: ${obj.username}\nAddress: ${obj.address}`;
  },
  getSetGen: getSetGen,
};

// Test
// Before using getSetGen
console.log(obj);

// Using GetSetGen
obj.getSetGen();
console.log(obj);
