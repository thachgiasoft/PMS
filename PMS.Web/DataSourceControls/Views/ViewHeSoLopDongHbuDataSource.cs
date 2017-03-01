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
	/// Represents the DataRepository.ViewHeSoLopDongHbuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewHeSoLopDongHbuDataSourceDesigner))]
	public class ViewHeSoLopDongHbuDataSource : ReadOnlyDataSource<ViewHeSoLopDongHbu>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLopDongHbuDataSource class.
		/// </summary>
		public ViewHeSoLopDongHbuDataSource() : base(new ViewHeSoLopDongHbuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewHeSoLopDongHbuDataSourceView used by the ViewHeSoLopDongHbuDataSource.
		/// </summary>
		protected ViewHeSoLopDongHbuDataSourceView ViewHeSoLopDongHbuView
		{
			get { return ( View as ViewHeSoLopDongHbuDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewHeSoLopDongHbuDataSourceView class that is to be
		/// used by the ViewHeSoLopDongHbuDataSource.
		/// </summary>
		/// <returns>An instance of the ViewHeSoLopDongHbuDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewHeSoLopDongHbu, Object> GetNewDataSourceView()
		{
			return new ViewHeSoLopDongHbuDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewHeSoLopDongHbuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewHeSoLopDongHbuDataSourceView : ReadOnlyDataSourceView<ViewHeSoLopDongHbu>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeSoLopDongHbuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewHeSoLopDongHbuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewHeSoLopDongHbuDataSourceView(ViewHeSoLopDongHbuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewHeSoLopDongHbuDataSource ViewHeSoLopDongHbuOwner
		{
			get { return Owner as ViewHeSoLopDongHbuDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewHeSoLopDongHbuService ViewHeSoLopDongHbuProvider
		{
			get { return Provider as ViewHeSoLopDongHbuService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewHeSoLopDongHbuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewHeSoLopDongHbuDataSource class.
	/// </summary>
	public class ViewHeSoLopDongHbuDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewHeSoLopDongHbu>
	{
	}

	#endregion ViewHeSoLopDongHbuDataSourceDesigner

	#region ViewHeSoLopDongHbuFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoLopDongHbu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoLopDongHbuFilter : SqlFilter<ViewHeSoLopDongHbuColumn>
	{
	}

	#endregion ViewHeSoLopDongHbuFilter

	#region ViewHeSoLopDongHbuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeSoLopDongHbu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeSoLopDongHbuExpressionBuilder : SqlExpressionBuilder<ViewHeSoLopDongHbuColumn>
	{
	}
	
	#endregion ViewHeSoLopDongHbuExpressionBuilder		
}

