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
	/// Represents the DataRepository.VChiTietQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VChiTietQuyDoiDataSourceDesigner))]
	public class VChiTietQuyDoiDataSource : ReadOnlyDataSource<VChiTietQuyDoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VChiTietQuyDoiDataSource class.
		/// </summary>
		public VChiTietQuyDoiDataSource() : base(new VChiTietQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VChiTietQuyDoiDataSourceView used by the VChiTietQuyDoiDataSource.
		/// </summary>
		protected VChiTietQuyDoiDataSourceView VChiTietQuyDoiView
		{
			get { return ( View as VChiTietQuyDoiDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VChiTietQuyDoiDataSourceView class that is to be
		/// used by the VChiTietQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the VChiTietQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<VChiTietQuyDoi, Object> GetNewDataSourceView()
		{
			return new VChiTietQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the VChiTietQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VChiTietQuyDoiDataSourceView : ReadOnlyDataSourceView<VChiTietQuyDoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VChiTietQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VChiTietQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VChiTietQuyDoiDataSourceView(VChiTietQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VChiTietQuyDoiDataSource VChiTietQuyDoiOwner
		{
			get { return Owner as VChiTietQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VChiTietQuyDoiService VChiTietQuyDoiProvider
		{
			get { return Provider as VChiTietQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VChiTietQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VChiTietQuyDoiDataSource class.
	/// </summary>
	public class VChiTietQuyDoiDataSourceDesigner : ReadOnlyDataSourceDesigner<VChiTietQuyDoi>
	{
	}

	#endregion VChiTietQuyDoiDataSourceDesigner

	#region VChiTietQuyDoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VChiTietQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VChiTietQuyDoiFilter : SqlFilter<VChiTietQuyDoiColumn>
	{
	}

	#endregion VChiTietQuyDoiFilter

	#region VChiTietQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VChiTietQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VChiTietQuyDoiExpressionBuilder : SqlExpressionBuilder<VChiTietQuyDoiColumn>
	{
	}
	
	#endregion VChiTietQuyDoiExpressionBuilder		
}

