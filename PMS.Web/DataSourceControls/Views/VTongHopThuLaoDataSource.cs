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
	/// Represents the DataRepository.VTongHopThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VTongHopThuLaoDataSourceDesigner))]
	public class VTongHopThuLaoDataSource : ReadOnlyDataSource<VTongHopThuLao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTongHopThuLaoDataSource class.
		/// </summary>
		public VTongHopThuLaoDataSource() : base(new VTongHopThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VTongHopThuLaoDataSourceView used by the VTongHopThuLaoDataSource.
		/// </summary>
		protected VTongHopThuLaoDataSourceView VTongHopThuLaoView
		{
			get { return ( View as VTongHopThuLaoDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VTongHopThuLaoDataSourceView class that is to be
		/// used by the VTongHopThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the VTongHopThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<VTongHopThuLao, Object> GetNewDataSourceView()
		{
			return new VTongHopThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the VTongHopThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VTongHopThuLaoDataSourceView : ReadOnlyDataSourceView<VTongHopThuLao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTongHopThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VTongHopThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VTongHopThuLaoDataSourceView(VTongHopThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VTongHopThuLaoDataSource VTongHopThuLaoOwner
		{
			get { return Owner as VTongHopThuLaoDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VTongHopThuLaoService VTongHopThuLaoProvider
		{
			get { return Provider as VTongHopThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VTongHopThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VTongHopThuLaoDataSource class.
	/// </summary>
	public class VTongHopThuLaoDataSourceDesigner : ReadOnlyDataSourceDesigner<VTongHopThuLao>
	{
	}

	#endregion VTongHopThuLaoDataSourceDesigner

	#region VTongHopThuLaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTongHopThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VTongHopThuLaoFilter : SqlFilter<VTongHopThuLaoColumn>
	{
	}

	#endregion VTongHopThuLaoFilter

	#region VTongHopThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTongHopThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VTongHopThuLaoExpressionBuilder : SqlExpressionBuilder<VTongHopThuLaoColumn>
	{
	}
	
	#endregion VTongHopThuLaoExpressionBuilder		
}

