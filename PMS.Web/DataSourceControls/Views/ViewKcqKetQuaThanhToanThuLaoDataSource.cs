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
	/// Represents the DataRepository.ViewKcqKetQuaThanhToanThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKcqKetQuaThanhToanThuLaoDataSourceDesigner))]
	public class ViewKcqKetQuaThanhToanThuLaoDataSource : ReadOnlyDataSource<ViewKcqKetQuaThanhToanThuLao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqKetQuaThanhToanThuLaoDataSource class.
		/// </summary>
		public ViewKcqKetQuaThanhToanThuLaoDataSource() : base(new ViewKcqKetQuaThanhToanThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKcqKetQuaThanhToanThuLaoDataSourceView used by the ViewKcqKetQuaThanhToanThuLaoDataSource.
		/// </summary>
		protected ViewKcqKetQuaThanhToanThuLaoDataSourceView ViewKcqKetQuaThanhToanThuLaoView
		{
			get { return ( View as ViewKcqKetQuaThanhToanThuLaoDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKcqKetQuaThanhToanThuLaoDataSourceView class that is to be
		/// used by the ViewKcqKetQuaThanhToanThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKcqKetQuaThanhToanThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKcqKetQuaThanhToanThuLao, Object> GetNewDataSourceView()
		{
			return new ViewKcqKetQuaThanhToanThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKcqKetQuaThanhToanThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKcqKetQuaThanhToanThuLaoDataSourceView : ReadOnlyDataSourceView<ViewKcqKetQuaThanhToanThuLao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqKetQuaThanhToanThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKcqKetQuaThanhToanThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKcqKetQuaThanhToanThuLaoDataSourceView(ViewKcqKetQuaThanhToanThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKcqKetQuaThanhToanThuLaoDataSource ViewKcqKetQuaThanhToanThuLaoOwner
		{
			get { return Owner as ViewKcqKetQuaThanhToanThuLaoDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKcqKetQuaThanhToanThuLaoService ViewKcqKetQuaThanhToanThuLaoProvider
		{
			get { return Provider as ViewKcqKetQuaThanhToanThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewKcqKetQuaThanhToanThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKcqKetQuaThanhToanThuLaoDataSource class.
	/// </summary>
	public class ViewKcqKetQuaThanhToanThuLaoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKcqKetQuaThanhToanThuLao>
	{
	}

	#endregion ViewKcqKetQuaThanhToanThuLaoDataSourceDesigner

	#region ViewKcqKetQuaThanhToanThuLaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqKetQuaThanhToanThuLaoFilter : SqlFilter<ViewKcqKetQuaThanhToanThuLaoColumn>
	{
	}

	#endregion ViewKcqKetQuaThanhToanThuLaoFilter

	#region ViewKcqKetQuaThanhToanThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqKetQuaThanhToanThuLaoExpressionBuilder : SqlExpressionBuilder<ViewKcqKetQuaThanhToanThuLaoColumn>
	{
	}
	
	#endregion ViewKcqKetQuaThanhToanThuLaoExpressionBuilder		
}

