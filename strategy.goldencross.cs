/*
'THE GOLDEN CROSS' Strategy
This demo is brought to you by the good human beings over @ Corta Bear. Visit us online @ www.cortabear.com
*/

#region Using declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui.Tools;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.NinjaScript.Indicators;
using NinjaTrader.NinjaScript.DrawingTools;
#endregion 

//This namespace holds Strategies in this folder and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Strategies
{
	public class DemoGoldenCrossStrategy : Strategy
	{
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"This demo is brought to you by the good human beings over @ Corta Bear. Visit us online @ www.cortabear.com.";
				Name										= "DemoGoldenCrossStrategy";
				Calculate									= Calculate.OnBarClose;
				EntriesPerDirection							= 1;
				EntryHandling								= EntryHandling.AllEntries;
				IsExitOnSessionCloseStrategy				= true;
				ExitOnSessionCloseSeconds					= 30;
				IsFillLimitOnTouch							= false;
				MaximumBarsLookBack							= MaximumBarsLookBack.TwoHundredFiftySix;
				OrderFillResolution							= OrderFillResolution.Standard;
				Slippage									= 0;
				StartBehavior								= StartBehavior.WaitUntilFlat;
				TimeInForce									= TimeInForce.Gtc;
				TraceOrders									= false;
				RealtimeErrorHandling						= RealtimeErrorHandling.StopCancelClose;
				StopTargetHandling							= StopTargetHandling.PerEntryExecution;
				BarsRequiredToTrade							= 20;
				// Disable this property for performance gains in Strategy Analyzer optimizations
				// See the Help Guide for additional information
				IsInstantiatedOnEachOptimizationIteration	= true;
			}
			else if (State == State.Configure)
			{

				/*
				STOP LOSS  
				Setting the stop loss for positions globally.

				Syntax
				- SetStopLoss( CalculationMode mode, double value )
				- SetProfitTarget( CalculationMode mode, double value )
				*/
				SetStopLoss( CalculationMode.Percent, .1 );
				SetProfitTarget( CalculationMode.Percent, .2 );

			}
		}

		protected override void OnBarUpdate()
		{
			/*
			SIMPLE MOVING AVERAGE (SMA)
			*/
			var sma10 = SMA(10);
			var sma20 = SMA(20);

			// Cross Above?
			if( CrossAbove(sma10, sma20, 1 )){
				EnterLong(); // 
			}
		}
	}
}
