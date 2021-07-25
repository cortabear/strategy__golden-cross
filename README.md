# Strategy : The Golden Cross
The Golden Cross Strategy Demo  
In this demo we will walk through the creation of the infamous '[Golden Cross Strategy](https://etfdb.com/etf-education/3-simple-moving-average-etf-trading-strategies/)' trading strategy using NinjaTrader 8.  

> IF the simple moving average (SMA) of the 'investment' in a 10 period timespan just moved up and crossed over the simple moving average (SMA) of the 20 period timespan THEN BUY the 'investment'. Set a stop loss at 10% loss and a profit target of 20%.  


## Table Of Conents  
1. [Getting Started](#)  
1. [Generating A Class](#)

## Getting Started 
1. [Prereq](#)  

---  

### Prereq  
**VS Code**  
Any solid IDE would suffice but we would recommend using Microsoft's VS Code editor for MAC, PC.  

[Go Back To The Table Of Contents...](#strategy--the-golden-cross)

NinjaTrader 8 downloaded and installed and hooked up to live data 
NinjaTrader account 

## Generating A Class  
**Launch NinjaTrader 8**  
![NinjaTrader 8 Loading Image](_assests/imgs/img-0001__ntrader-Lol.png)  

[Go Back To The Table Of Contents...](#strategy--the-golden-cross)  

---  

**Control Center > Strategy Builder**  
From the control center, navigate to the [Strategy Builder](#).  
![NinjaTrader 8 Loading Image](_assests/imgs/img-0002__control-center.png)  

The [Strategy Builder](#) wizard will load.  

[Go Back To The Table Of Contents...](#strategy--the-golden-cross)  

---  


**Create a new Strategy**  
This wizard guides you though the steps of creating a new strategy.  
* General - Name and description of the strategy.  
* Default Properties -  
* Additional Data -  
* Inputs and Variables -  
* Conditions and Actions -  
* Stops and Targets -  
* Finish -  
![NinjaTrader 8 Loading Image](_assests/imgs/img-0003__strategy-builder.png)  
Click "Next"

[Go Back To The Table Of Contents...](#strategy--the-golden-cross)  

---  
 

**General: Strategy Name & Description**  
Enter a name and description for your custom strategy.  
**Name**: 'DemoGoldenCrossStrategy'  
**Description**: 'This demo is brought to you by the good human beings over @ Corta Bear. Visit us online @ www.cortabear.com'  
![NinjaTrader 8 Loading Image](_assests/imgs/img-0003__strategy-name.png)  
Click "Unlock Code"

[Go Back To The Table Of Contents...](#strategy--the-golden-cross)  

---  
 

**Unlocking Code**  
"After unlocking, you can manually edit the wizard generated code. However, you will no longer be able to configure the strategy with the wizard. Do you want to proceed?" Click "Yes"  
![NinjaTrader 8 Loading Image](_assests/imgs/img-0004__unlock-code.png)  
Click "Unlock Code"

[Go Back To The Table Of Contents...](#strategy--the-golden-cross)  

---  
 

**NinjaScript Editor**  
We now have a C# Class that provides us a template for a strategy.
![NinjaTrader 8 Loading Image](_assests/imgs/img-0005__ninja-script-editor.png)  

**Declarations**  
As with all C# files there are a series of declarations at the top of the file.

The class that has been created inherits from 'Strategy'. 'Strategy' comes from a 'NinjaTrader.Strategy.Strategy' DLL.

**Stadard Variables & Methods**  
Every strategy comes with a default set of variables and methods.

**Initialize()**  
Whenever this strategy is loaded

**OnBarUpdate()**  
Whenever ever the candle closes.  

[Go Back To The Table Of Contents...](#strategy--the-golden-cross)  

---  
