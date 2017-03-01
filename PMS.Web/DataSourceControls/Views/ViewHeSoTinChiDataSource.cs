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
	/// Represents the DataRepository.ViewHeSoTinChiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewHeSoTinChiDataSourceDesigner))]
	public class ViewHeSoTinChiDataSource : ReadOnlyDataSource<ViewHeSoTinChi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoTinChiDataSource class.
		/// </summary>
		public ViewHeSoTinChiDataSource() : base(new ViewHeSoTinChiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewHeSoTinChiDataSourceView used by the ViewHeSoTinChiDataSource.
		/// </summary>
		protected ViewHeSoTinChiDataSourceView ViewHeSoTinChiView
		{
			get { return ( View as ViewHeSoTinChiDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewHeSoTinChiDataSourceView class that is to be
		/// used by the ViewHeSoTinChiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewHeSoTinChiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewHeSoTinChi, Object> GetNewDataSourceView()
		{
			return new ViewHeSoTinChiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewHeSoTinChiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewHeSoTinChiDataSourceView : ReadOnlyDataSourceView<ViewHeSoTinChi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoTinChiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewHeSoTinChiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewHeSoTinChiDataSourceView(ViewHeSoTinChiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewHeSoTinChiDataSource ViewHeSoTinChiOwner
		{
			get { return Owner as ViewHeSoTinChiDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewHeSoTinChiService ViewHeSoTinChiProvider
		{
			get { return Provider as ViewHeSoTinChiService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewHeSoTinChiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewHeSoTinChiDataSource class.
	/// </summary>
	public class ViewHeSoTinChiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewHeSoTinChi>
	{
	}

	#endregion ViewHeSoTinChiDataSourceDesigner

	#region ViewHeSoTinChiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoTinChiFilter : SqlFilter<ViewHeSoTinChiColumn>
	{
	}

	#endregion ViewHeSoTinChiFilter

	#region ViewHeSoTinChiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoTinChiExpressionBuilder : SqlExpressionBuilder<ViewHeSoTinChiColumn>
	{
	}
	
	#endregion ViewHeSoTinChiExpressionBuilder		
}

