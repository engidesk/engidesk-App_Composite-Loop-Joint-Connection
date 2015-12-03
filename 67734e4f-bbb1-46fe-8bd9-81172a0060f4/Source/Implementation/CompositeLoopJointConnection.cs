using System;
using Inca.Commons.Datatypes.Models;
using Inca.Commons.DotNetTool;

namespace Engidesk.BKEKJNWC.CompositeLoopJointConnection.Revision00003
{
	public class CompositeLoopJointConnection : DotNetElement, Engidesk.BKEKJNWC.CompositeLoopJointConnection.Revision00003.Contracts.ICompositeLoopJointConnection
	{
		#region Generated Properties
		
		private double _privateBolzenkraft;

		/// <summary>
        /// Bolzenkraft
        /// </summary>
        /// <remarks>
        /// Unit: N
        /// </remarks>
		public double Bolzenkraft 
		{ 
			get { return _privateBolzenkraft; } 
			set
			{
				if (_privateBolzenkraft == value) return;
				_privateBolzenkraft = value;
				RaisePropertyChanged(() => Bolzenkraft);
			}				 
		}
		
		private double _privateInnenradius;

		/// <summary>
        /// Innenradius
        /// </summary>
        /// <remarks>
        /// Unit: mm
        /// </remarks>
		public double Innenradius 
		{ 
			get { return _privateInnenradius; } 
			set
			{
				if (_privateInnenradius == value) return;
				_privateInnenradius = value;
				RaisePropertyChanged(() => Innenradius);
			}				 
		}
		
		private double _privateAuenradius;

		/// <summary>
        /// Auenradius
        /// </summary>
        /// <remarks>
        /// Unit: mm
        /// </remarks>
		public double Auenradius 
		{ 
			get { return _privateAuenradius; } 
			set
			{
				if (_privateAuenradius == value) return;
				_privateAuenradius = value;
				RaisePropertyChanged(() => Auenradius);
			}				 
		}
		
		private double _privateBreite;

		/// <summary>
        /// Breite
        /// </summary>
        /// <remarks>
        /// Unit: mm
        /// </remarks>
		public double Breite 
		{ 
			get { return _privateBreite; } 
			set
			{
				if (_privateBreite == value) return;
				_privateBreite = value;
				RaisePropertyChanged(() => Breite);
			}				 
		}
		
		private double _privateEModulParallel;

		/// <summary>
        /// EModulParallel
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public double EModulParallel 
		{ 
			get { return _privateEModulParallel; } 
			set
			{
				if (_privateEModulParallel == value) return;
				_privateEModulParallel = value;
				RaisePropertyChanged(() => EModulParallel);
			}				 
		}
		
		private double _privateEModulSenkrecht;

		/// <summary>
        /// EModulSenkrecht
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public double EModulSenkrecht 
		{ 
			get { return _privateEModulSenkrecht; } 
			set
			{
				if (_privateEModulSenkrecht == value) return;
				_privateEModulSenkrecht = value;
				RaisePropertyChanged(() => EModulSenkrecht);
			}				 
		}
		
		private double _privateQuerkontraktionszahlparallelsenkrecht;

		/// <summary>
        /// Große Querkontraktionszahl
        /// </summary>
        /// <remarks>
        /// Unit: -
        /// </remarks>
		public double Querkontraktionszahlparallelsenkrecht 
		{ 
			get { return _privateQuerkontraktionszahlparallelsenkrecht; } 
			set
			{
				if (_privateQuerkontraktionszahlparallelsenkrecht == value) return;
				_privateQuerkontraktionszahlparallelsenkrecht = value;
				RaisePropertyChanged(() => Querkontraktionszahlparallelsenkrecht);
			}				 
		}
		
		private double _privateQuerkontraktionszahlsenkrechtparallel;

		/// <summary>
        /// Kleine Querkontraktionszahl
        /// </summary>
        /// <remarks>
        /// Unit: -
        /// </remarks>
		public double Querkontraktionszahlsenkrechtparallel 
		{ 
			get { return _privateQuerkontraktionszahlsenkrechtparallel; } 
			set
			{
				if (_privateQuerkontraktionszahlsenkrechtparallel == value) return;
				_privateQuerkontraktionszahlsenkrechtparallel = value;
				RaisePropertyChanged(() => Querkontraktionszahlsenkrechtparallel);
			}				 
		}
		
		private double _privateQuerkontraktionszahlsenkrechtsenkrecht;

		/// <summary>
        /// typische Annahme: 0.4
        /// </summary>
        /// <remarks>
        /// Unit: -
        /// </remarks>
		public double Querkontraktionszahlsenkrechtsenkrecht 
		{ 
			get { return _privateQuerkontraktionszahlsenkrechtsenkrecht; } 
			set
			{
				if (_privateQuerkontraktionszahlsenkrechtsenkrecht == value) return;
				_privateQuerkontraktionszahlsenkrechtsenkrecht = value;
				RaisePropertyChanged(() => Querkontraktionszahlsenkrechtsenkrecht);
			}				 
		}
		
		private double _privateRadiusr;

		/// <summary>
        /// Radiusr
        /// </summary>
        /// <remarks>
        /// Unit: mm
        /// </remarks>
		public double Radiusr 
		{ 
			get { return _privateRadiusr; } 
			set
			{
				if (_privateRadiusr == value) return;
				_privateRadiusr = value;
				RaisePropertyChanged(() => Radiusr);
			}				 
		}
		
		private bool _privateSchlaufewirdseitlichgestuetzt;

		/// <summary>
        /// Schlaufewirdseitlichgestuetzt
        /// </summary>
        /// <remarks>
        /// Unit: n.a.
        /// </remarks>
		public bool Schlaufewirdseitlichgestuetzt 
		{ 
			get { return _privateSchlaufewirdseitlichgestuetzt; } 
			set
			{
				if (_privateSchlaufewirdseitlichgestuetzt == value) return;
				_privateSchlaufewirdseitlichgestuetzt = value;
				RaisePropertyChanged(() => Schlaufewirdseitlichgestuetzt);
			}				 
		}
		
		private double _privateLeibungsdruck;

		/// <summary>
        /// Leibungsdruck
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public double Leibungsdruck 
		{ 
			get { return _privateLeibungsdruck; } 
			set
			{
				if (_privateLeibungsdruck == value) return;
				_privateLeibungsdruck = value;
				RaisePropertyChanged(() => Leibungsdruck);
			}				 
		}
		
		private double _privateRadialspannungRadius;

		/// <summary>
        /// RadialspannungRadius
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public double RadialspannungRadius 
		{ 
			get { return _privateRadialspannungRadius; } 
			set
			{
				if (_privateRadialspannungRadius == value) return;
				_privateRadialspannungRadius = value;
				RaisePropertyChanged(() => RadialspannungRadius);
			}				 
		}
		
		private double _privateMaximaleRadialspannung;

		/// <summary>
        /// MaximaleRadialspannung
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public double MaximaleRadialspannung 
		{ 
			get { return _privateMaximaleRadialspannung; } 
			set
			{
				if (_privateMaximaleRadialspannung == value) return;
				_privateMaximaleRadialspannung = value;
				RaisePropertyChanged(() => MaximaleRadialspannung);
			}				 
		}
		
		private Engidesk.Types.Function.Function _privateRadialspannungr;

		/// <summary>
        /// Radialspannungr
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public Engidesk.Types.Function.Function Radialspannungr 
		{ 
			get { return _privateRadialspannungr; } 
			set
			{
				if (_privateRadialspannungr == value) return;
				_privateRadialspannungr = value;
				RaisePropertyChanged(() => Radialspannungr);
			}				 
		}
		
		private double _privateMaximaleTangentialspannung;

		/// <summary>
        /// MaximaleTangentialspannung
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public double MaximaleTangentialspannung 
		{ 
			get { return _privateMaximaleTangentialspannung; } 
			set
			{
				if (_privateMaximaleTangentialspannung == value) return;
				_privateMaximaleTangentialspannung = value;
				RaisePropertyChanged(() => MaximaleTangentialspannung);
			}				 
		}
		
		private Engidesk.Types.Function.Function _privateTangentialspannungr;

		/// <summary>
        /// Tangentialspannungr
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public Engidesk.Types.Function.Function Tangentialspannungr 
		{ 
			get { return _privateTangentialspannungr; } 
			set
			{
				if (_privateTangentialspannungr == value) return;
				_privateTangentialspannungr = value;
				RaisePropertyChanged(() => Tangentialspannungr);
			}				 
		}
		
		private double _privateTangentialspannungRadius;

		/// <summary>
        /// TangentialspannungRadius
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public double TangentialspannungRadius 
		{ 
			get { return _privateTangentialspannungRadius; } 
			set
			{
				if (_privateTangentialspannungRadius == value) return;
				_privateTangentialspannungRadius = value;
				RaisePropertyChanged(() => TangentialspannungRadius);
			}				 
		}
		
		private double _privateAxialspannungRadius;

		/// <summary>
        /// AxialspannungRadius
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public double AxialspannungRadius 
		{ 
			get { return _privateAxialspannungRadius; } 
			set
			{
				if (_privateAxialspannungRadius == value) return;
				_privateAxialspannungRadius = value;
				RaisePropertyChanged(() => AxialspannungRadius);
			}				 
		}
		
		private double _privateMaximaleAxialspannung;

		/// <summary>
        /// MaximaleAxialspannung
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public double MaximaleAxialspannung 
		{ 
			get { return _privateMaximaleAxialspannung; } 
			set
			{
				if (_privateMaximaleAxialspannung == value) return;
				_privateMaximaleAxialspannung = value;
				RaisePropertyChanged(() => MaximaleAxialspannung);
			}				 
		}
		
		private Engidesk.Types.Function.Function _privateVerlaufderAxialspannung;

		/// <summary>
        /// VerlaufderAxialspannung
        /// </summary>
        /// <remarks>
        /// Unit: N/mm²
        /// </remarks>
		public Engidesk.Types.Function.Function VerlaufderAxialspannung 
		{ 
			get { return _privateVerlaufderAxialspannung; } 
			set
			{
				if (_privateVerlaufderAxialspannung == value) return;
				_privateVerlaufderAxialspannung = value;
				RaisePropertyChanged(() => VerlaufderAxialspannung);
			}				 
		}
   #endregion // Generated Properties










	    public double radialspannung(double leibungsdruck, double ev, double innenradius, double aussenradius,
	        double radius)
	    {
	        double result;

	        result = -leibungsdruck*Math.Pow(innenradius, 1 + ev)/
	                 (Math.Pow(innenradius, 2*ev) - Math.Pow(aussenradius, 2*ev))*Math.Pow(radius, ev - 1) +
	                 (-leibungsdruck)*Math.Pow(innenradius, 1 - ev)/
	                 (Math.Pow(innenradius, -2*ev) - Math.Pow(aussenradius, -2*ev))*Math.Pow(radius, -ev - 1);
	        return result;
	    }


	    public double tangentialspannung(double leibungsdruck, double ev, double innenradius, double aussenradius,
	        double radius)
	    {
	        double result;

	        result = -leibungsdruck*ev*
	                 (Math.Pow(innenradius, 1 + ev)/(Math.Pow(innenradius, 2*ev) - Math.Pow(aussenradius, 2*ev))*
	                  Math.Pow(radius, ev - 1) -
	                  (Math.Pow(innenradius, 1 - ev)/(Math.Pow(innenradius, -2*ev) - Math.Pow(aussenradius, -2*ev))*
	                   Math.Pow(radius, -ev - 1)));

	        return result;
	    }

	    public double axialspannung(double querkontraktionszahlSenkrechtSenkrecht, double radialsp, double tangentialsp, double esenkrecht,
	        double eparallel, double querkontraktionszahlsenkrechtparallel)
	    {
	        double result;

	        result = esenkrecht*
	                 (querkontraktionszahlSenkrechtSenkrecht*radialsp/esenkrecht +
	                  querkontraktionszahlsenkrechtparallel*tangentialsp/eparallel);

	        return result;

	    }


	    public override void Process()
		{
		    Radialspannungr.Clear();
		    Tangentialspannungr.Clear();

		    double EparallelStrich = EModulParallel/
		                             (1 - Querkontraktionszahlparallelsenkrecht*Querkontraktionszahlsenkrechtparallel);

		    double ESenkrechtStrich = EModulSenkrecht/(1 - Querkontraktionszahlsenkrechtsenkrecht*Querkontraktionszahlsenkrechtsenkrecht);

		    double Ev = Math.Pow(EparallelStrich/ESenkrechtStrich,0.5);

		    Leibungsdruck = Bolzenkraft/(2*Innenradius*Breite);

            //Berechnung der Radialspannung
		    MaximaleRadialspannung = radialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Innenradius);

            RadialspannungRadius = radialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Radiusr);

		    for (int i = 0; i < 11; i++)
		    {
                var value = radialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Innenradius+i*(Auenradius-Innenradius)/10);
                Radialspannungr.AddNode(Innenradius + i * (Auenradius - Innenradius) / 10,value);
		    }


            //Berechnung der Tangentialspannung
            MaximaleTangentialspannung = tangentialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Innenradius);

            TangentialspannungRadius = tangentialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Radiusr);

	        for (int i = 0; i < 11; i++)
	        {
                var value = tangentialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Innenradius + i * (Auenradius - Innenradius) / 10);
                Tangentialspannungr.AddNode(Innenradius + i * (Auenradius - Innenradius) / 10, value);
	        }

            

	        if (Schlaufewirdseitlichgestuetzt)
	        {
	            MaximaleAxialspannung = axialspannung(Querkontraktionszahlsenkrechtsenkrecht,
	                radialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Innenradius),
	                tangentialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Innenradius), EModulSenkrecht,
	                EModulParallel, Querkontraktionszahlsenkrechtparallel);
                AxialspannungRadius = axialspannung(Querkontraktionszahlsenkrechtsenkrecht,
                    radialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Radiusr),
                    tangentialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Radiusr), EModulSenkrecht,
                    EModulParallel, Querkontraktionszahlsenkrechtparallel);

	            for (int i = 0; i < 11; i++)
	            {
                    var value = axialspannung(Querkontraktionszahlsenkrechtsenkrecht,
                    radialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Innenradius + i * (Auenradius - Innenradius) / 10),
                    tangentialspannung(Leibungsdruck, Ev, Innenradius, Auenradius, Innenradius + i * (Auenradius - Innenradius) / 10), EModulSenkrecht,
                    EModulParallel, Querkontraktionszahlsenkrechtparallel);
                    VerlaufderAxialspannung.AddNode(Innenradius + i * (Auenradius - Innenradius) / 10,value);
	            }

	        }
	        else
	        {
	            MaximaleAxialspannung = 0;
	            AxialspannungRadius = 0;
	        }



		}
	}
}