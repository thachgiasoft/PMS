#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ViewDonViProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewDonViDataSourceDesigner))]
	public class ViewDonViDataSource : ReadOnlyDataSource<ViewDonVi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDonViDataSource class.
		/// </summary>
		public ViewDonViDataSource() : base(new ViewDonViService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewDonViDataSourceView used by the ViewDonViDataSource.
		/// </summary>
		protected ViewDonViDataSourceView ViewDonViView
		{
			get { return ( View as ViewDonViDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewDonViDataSourceView class that is to be
		/// used by the ViewDonViDataSource.
		/// </summary>
		/// <returns>An instance of the ViewDonViDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewDonVi, Object> GetNewDataSourceView()
		{
			return new ViewDonViDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the ViewDonViDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewDonViDataSourceView : ReadOnlyDataSourceView<ViewDonVi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDonViDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewDonViDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewDonViDataSourceView(ViewDonViDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewDonViDataSource ViewDonViOwner
		{
			get { return Owner as ViewDonViDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewDonViService ViewDonViProvider
		{
			get { return Provider as ViewDonViService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewDonViDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewDonViDataSource class.
	/// </summary>
	public class ViewDonViDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewDonVi>
	{
	}

	#endregion ViewDonViDataSourceDesigner

	#region ViewDonViFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDonVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDonViFilter : SqlFilter<ViewDonViColumn>
	{
	}

	#endregion ViewDonViFilter

	#region ViewDonViExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDonVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDonViExpressionBuilder : SqlExpressionBuilder<ViewDonViColumn>
	{
	}
	
	#endregion ViewDonViExpressionBuilder		
}

