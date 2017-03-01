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
	/// Represents the DataRepository.VThanhToanThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VThanhToanThuLaoDataSourceDesigner))]
	public class VThanhToanThuLaoDataSource : ReadOnlyDataSource<VThanhToanThuLao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VThanhToanThuLaoDataSource class.
		/// </summary>
		public VThanhToanThuLaoDataSource() : base(new VThanhToanThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VThanhToanThuLaoDataSourceView used by the VThanhToanThuLaoDataSource.
		/// </summary>
		protected VThanhToanThuLaoDataSourceView VThanhToanThuLaoView
		{
			get { return ( View as VThanhToanThuLaoDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VThanhToanThuLaoDataSourceView class that is to be
		/// used by the VThanhToanThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the VThanhToanThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<VThanhToanThuLao, Object> GetNewDataSourceView()
		{
			return new VThanhToanThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the VThanhToanThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VThanhToanThuLaoDataSourceView : ReadOnlyDataSourceView<VThanhToanThuLao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VThanhToanThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VThanhToanThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VThanhToanThuLaoDataSourceView(VThanhToanThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VThanhToanThuLaoDataSource VThanhToanThuLaoOwner
		{
			get { return Owner as VThanhToanThuLaoDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VThanhToanThuLaoService VThanhToanThuLaoProvider
		{
			get { return Provider as VThanhToanThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VThanhToanThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VThanhToanThuLaoDataSource class.
	/// </summary>
	public class VThanhToanThuLaoDataSourceDesigner : ReadOnlyDataSourceDesigner<VThanhToanThuLao>
	{
	}

	#endregion VThanhToanThuLaoDataSourceDesigner

	#region VThanhToanThuLaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VThanhToanThuLaoFilter : SqlFilter<VThanhToanThuLaoColumn>
	{
	}

	#endregion VThanhToanThuLaoFilter

	#region VThanhToanThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VThanhToanThuLaoExpressionBuilder : SqlExpressionBuilder<VThanhToanThuLaoColumn>
	{
	}
	
	#endregion VThanhToanThuLaoExpressionBuilder		
}

