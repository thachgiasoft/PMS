﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'History' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IHistory 
	{
		/// <summary>			
		/// HistoryID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "History"</remarks>
		System.Int64 HistoryId { get; set; }
				
		
		
		/// <summary>
		/// OldProfessor : 
		/// </summary>
		System.String  OldProfessor  { get; set; }
		
		/// <summary>
		/// NewProfessor : 
		/// </summary>
		System.String  NewProfessor  { get; set; }
		
		/// <summary>
		/// Username : 
		/// </summary>
		System.String  Username  { get; set; }
		
		/// <summary>
		/// ComputerName : 
		/// </summary>
		System.String  ComputerName  { get; set; }
		
		/// <summary>
		/// UpdatedDate : 
		/// </summary>
		System.DateTime  UpdatedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

