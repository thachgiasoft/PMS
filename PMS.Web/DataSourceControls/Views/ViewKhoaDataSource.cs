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
	/// Represents the DataRepository.ViewKhoaProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKhoaDataSourceDesigner))]
	public class ViewKhoaDataSource : ReadOnlyDataSource<ViewKhoa>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaDataSource class.
		/// </summary>
		public ViewKhoaDataSource() : base(new ViewKhoaService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKhoaDataSourceView used by the ViewKhoaDataSource.
		/// </summary>
		protected ViewKhoaDataSourceView ViewKhoaView
		{
			get { return ( View as ViewKhoaDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKhoaDataSourceView class that is to be
		/// used by the ViewKhoaDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKhoaDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKhoa, Object> GetNewDataSourceView()
		{
			return new ViewKhoaDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKhoaDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKhoaDataSourceView : ReadOnlyDataSourceView<ViewKhoa>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKhoaDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKhoaDataSourceView(ViewKhoaDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKhoaDataSource ViewKhoaOwner
		{
			get { return Owner as ViewKhoaDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKhoaService ViewKhoaProvider
		{
			get { return Provider as ViewKhoaService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewKhoaDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKhoaDataSource class.
	/// </summary>
	public class ViewKhoaDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKhoa>
	{
	}

	#endregion ViewKhoaDataSourceDesigner

	#region ViewKhoaFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaFilter : SqlFilter<ViewKhoaColumn>
	{
	}

	#endregion ViewKhoaFilter

	#region ViewKhoaExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaExpressionBuilder : SqlExpressionBuilder<ViewKhoaColumn>
	{
	}
	
	#endregion ViewKhoaExpressionBuilder		
}

