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
	/// Represents the DataRepository.ViewHeSoLuongHocHamHocViProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewHeSoLuongHocHamHocViDataSourceDesigner))]
	public class ViewHeSoLuongHocHamHocViDataSource : ReadOnlyDataSource<ViewHeSoLuongHocHamHocVi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLuongHocHamHocViDataSource class.
		/// </summary>
		public ViewHeSoLuongHocHamHocViDataSource() : base(new ViewHeSoLuongHocHamHocViService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewHeSoLuongHocHamHocViDataSourceView used by the ViewHeSoLuongHocHamHocViDataSource.
		/// </summary>
		protected ViewHeSoLuongHocHamHocViDataSourceView ViewHeSoLuongHocHamHocViView
		{
			get { return ( View as ViewHeSoLuongHocHamHocViDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewHeSoLuongHocHamHocViDataSourceView class that is to be
		/// used by the ViewHeSoLuongHocHamHocViDataSource.
		/// </summary>
		/// <returns>An instance of the ViewHeSoLuongHocHamHocViDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewHeSoLuongHocHamHocVi, Object> GetNewDataSourceView()
		{
			return new ViewHeSoLuongHocHamHocViDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewHeSoLuongHocHamHocViDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewHeSoLuongHocHamHocViDataSourceView : ReadOnlyDataSourceView<ViewHeSoLuongHocHamHocVi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLuongHocHamHocViDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewHeSoLuongHocHamHocViDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewHeSoLuongHocHamHocViDataSourceView(ViewHeSoLuongHocHamHocViDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewHeSoLuongHocHamHocViDataSource ViewHeSoLuongHocHamHocViOwner
		{
			get { return Owner as ViewHeSoLuongHocHamHocViDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewHeSoLuongHocHamHocViService ViewHeSoLuongHocHamHocViProvider
		{
			get { return Provider as ViewHeSoLuongHocHamHocViService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewHeSoLuongHocHamHocViDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewHeSoLuongHocHamHocViDataSource class.
	/// </summary>
	public class ViewHeSoLuongHocHamHocViDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewHeSoLuongHocHamHocVi>
	{
	}

	#endregion ViewHeSoLuongHocHamHocViDataSourceDesigner

	#region ViewHeSoLuongHocHamHocViFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoLuongHocHamHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoLuongHocHamHocViFilter : SqlFilter<ViewHeSoLuongHocHamHocViColumn>
	{
	}

	#endregion ViewHeSoLuongHocHamHocViFilter

	#region ViewHeSoLuongHocHamHocViExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoLuongHocHamHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoLuongHocHamHocViExpressionBuilder : SqlExpressionBuilder<ViewHeSoLuongHocHamHocViColumn>
	{
	}
	
	#endregion ViewHeSoLuongHocHamHocViExpressionBuilder		
}

