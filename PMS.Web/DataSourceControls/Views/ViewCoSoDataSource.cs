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
	/// Represents the DataRepository.ViewCoSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewCoSoDataSourceDesigner))]
	public class ViewCoSoDataSource : ReadOnlyDataSource<ViewCoSo>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCoSoDataSource class.
		/// </summary>
		public ViewCoSoDataSource() : base(new ViewCoSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewCoSoDataSourceView used by the ViewCoSoDataSource.
		/// </summary>
		protected ViewCoSoDataSourceView ViewCoSoView
		{
			get { return ( View as ViewCoSoDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewCoSoDataSourceView class that is to be
		/// used by the ViewCoSoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewCoSoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewCoSo, Object> GetNewDataSourceView()
		{
			return new ViewCoSoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewCoSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewCoSoDataSourceView : ReadOnlyDataSourceView<ViewCoSo>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCoSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewCoSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewCoSoDataSourceView(ViewCoSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewCoSoDataSource ViewCoSoOwner
		{
			get { return Owner as ViewCoSoDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewCoSoService ViewCoSoProvider
		{
			get { return Provider as ViewCoSoService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewCoSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewCoSoDataSource class.
	/// </summary>
	public class ViewCoSoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewCoSo>
	{
	}

	#endregion ViewCoSoDataSourceDesigner

	#region ViewCoSoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCoSoFilter : SqlFilter<ViewCoSoColumn>
	{
	}

	#endregion ViewCoSoFilter

	#region ViewCoSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCoSoExpressionBuilder : SqlExpressionBuilder<ViewCoSoColumn>
	{
	}
	
	#endregion ViewCoSoExpressionBuilder		
}

