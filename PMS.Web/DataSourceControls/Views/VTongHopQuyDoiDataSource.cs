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
	/// Represents the DataRepository.VTongHopQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VTongHopQuyDoiDataSourceDesigner))]
	public class VTongHopQuyDoiDataSource : ReadOnlyDataSource<VTongHopQuyDoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTongHopQuyDoiDataSource class.
		/// </summary>
		public VTongHopQuyDoiDataSource() : base(new VTongHopQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VTongHopQuyDoiDataSourceView used by the VTongHopQuyDoiDataSource.
		/// </summary>
		protected VTongHopQuyDoiDataSourceView VTongHopQuyDoiView
		{
			get { return ( View as VTongHopQuyDoiDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VTongHopQuyDoiDataSourceView class that is to be
		/// used by the VTongHopQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the VTongHopQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<VTongHopQuyDoi, Object> GetNewDataSourceView()
		{
			return new VTongHopQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the VTongHopQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VTongHopQuyDoiDataSourceView : ReadOnlyDataSourceView<VTongHopQuyDoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTongHopQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VTongHopQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VTongHopQuyDoiDataSourceView(VTongHopQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VTongHopQuyDoiDataSource VTongHopQuyDoiOwner
		{
			get { return Owner as VTongHopQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VTongHopQuyDoiService VTongHopQuyDoiProvider
		{
			get { return Provider as VTongHopQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VTongHopQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VTongHopQuyDoiDataSource class.
	/// </summary>
	public class VTongHopQuyDoiDataSourceDesigner : ReadOnlyDataSourceDesigner<VTongHopQuyDoi>
	{
	}

	#endregion VTongHopQuyDoiDataSourceDesigner

	#region VTongHopQuyDoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTongHopQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VTongHopQuyDoiFilter : SqlFilter<VTongHopQuyDoiColumn>
	{
	}

	#endregion VTongHopQuyDoiFilter

	#region VTongHopQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTongHopQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VTongHopQuyDoiExpressionBuilder : SqlExpressionBuilder<VTongHopQuyDoiColumn>
	{
	}
	
	#endregion VTongHopQuyDoiExpressionBuilder		
}

