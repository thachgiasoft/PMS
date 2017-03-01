#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.NhomQuyenProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(NhomQuyenDataSourceDesigner))]
	public class NhomQuyenDataSource : ProviderDataSource<NhomQuyen, NhomQuyenKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomQuyenDataSource class.
		/// </summary>
		public NhomQuyenDataSource() : base(new NhomQuyenService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the NhomQuyenDataSourceView used by the NhomQuyenDataSource.
		/// </summary>
		protected NhomQuyenDataSourceView NhomQuyenView
		{
			get { return ( View as NhomQuyenDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the NhomQuyenDataSource control invokes to retrieve data.
		/// </summary>
		public NhomQuyenSelectMethod SelectMethod
		{
			get
			{
				NhomQuyenSelectMethod selectMethod = NhomQuyenSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (NhomQuyenSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the NhomQuyenDataSourceView class that is to be
		/// used by the NhomQuyenDataSource.
		/// </summary>
		/// <returns>An instance of the NhomQuyenDataSourceView class.</returns>
		protected override BaseDataSourceView<NhomQuyen, NhomQuyenKey> GetNewDataSourceView()
		{
			return new NhomQuyenDataSourceView(this, DefaultViewName);
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
	/// Supports the NhomQuyenDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class NhomQuyenDataSourceView : ProviderDataSourceView<NhomQuyen, NhomQuyenKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomQuyenDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the NhomQuyenDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public NhomQuyenDataSourceView(NhomQuyenDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal NhomQuyenDataSource NhomQuyenOwner
		{
			get { return Owner as NhomQuyenDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal NhomQuyenSelectMethod SelectMethod
		{
			get { return NhomQuyenOwner.SelectMethod; }
			set { NhomQuyenOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal NhomQuyenService NhomQuyenProvider
		{
			get { return Provider as NhomQuyenService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<NhomQuyen> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<NhomQuyen> results = null;
			NhomQuyen item;
			count = 0;
			
			System.Int32 _maNhomQuyen;
			System.Int32 _maChucNang;
			System.Int32 sp685_MaNhomQuyen;

			switch ( SelectMethod )
			{
				case NhomQuyenSelectMethod.Get:
					NhomQuyenKey entityKey  = new NhomQuyenKey();
					entityKey.Load(values);
					item = NhomQuyenProvider.Get(entityKey);
					results = new TList<NhomQuyen>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case NhomQuyenSelectMethod.GetAll:
                    results = NhomQuyenProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case NhomQuyenSelectMethod.GetPaged:
					results = NhomQuyenProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case NhomQuyenSelectMethod.Find:
					if ( FilterParameters != null )
						results = NhomQuyenProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = NhomQuyenProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case NhomQuyenSelectMethod.GetByMaNhomQuyen:
					_maNhomQuyen = ( values["MaNhomQuyen"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhomQuyen"], typeof(System.Int32)) : (int)0;
					item = NhomQuyenProvider.GetByMaNhomQuyen(_maNhomQuyen);
					results = new TList<NhomQuyen>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				case NhomQuyenSelectMethod.GetByMaChucNangFromNhomChucNang:
					_maChucNang = ( values["MaChucNang"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaChucNang"], typeof(System.Int32)) : (int)0;
					results = NhomQuyenProvider.GetByMaChucNangFromNhomChucNang(_maChucNang, this.StartIndex, this.PageSize, out count);
					break;
				// Custom
				case NhomQuyenSelectMethod.GetByNhomQuyenQL:
					sp685_MaNhomQuyen = (System.Int32) EntityUtil.ChangeType(values["MaNhomQuyen"], typeof(System.Int32));
					results = NhomQuyenProvider.GetByNhomQuyenQL(sp685_MaNhomQuyen, StartIndex, PageSize);
					break;
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == NhomQuyenSelectMethod.Get || SelectMethod == NhomQuyenSelectMethod.GetByMaNhomQuyen )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				NhomQuyen entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					NhomQuyenProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<NhomQuyen> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			NhomQuyenProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region NhomQuyenDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the NhomQuyenDataSource class.
	/// </summary>
	public class NhomQuyenDataSourceDesigner : ProviderDataSourceDesigner<NhomQuyen, NhomQuyenKey>
	{
		/// <summary>
		/// Initializes a new instance of the NhomQuyenDataSourceDesigner class.
		/// </summary>
		public NhomQuyenDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NhomQuyenSelectMethod SelectMethod
		{
			get { return ((NhomQuyenDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new NhomQuyenDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region NhomQuyenDataSourceActionList

	/// <summary>
	/// Supports the NhomQuyenDataSourceDesigner class.
	/// </summary>
	internal class NhomQuyenDataSourceActionList : DesignerActionList
	{
		private NhomQuyenDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the NhomQuyenDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public NhomQuyenDataSourceActionList(NhomQuyenDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NhomQuyenSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion NhomQuyenDataSourceActionList
	
	#endregion NhomQuyenDataSourceDesigner
	
	#region NhomQuyenSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the NhomQuyenDataSource.SelectMethod property.
	/// </summary>
	public enum NhomQuyenSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaNhomQuyen method.
		/// </summary>
		GetByMaNhomQuyen,
		/// <summary>
		/// Represents the GetByMaChucNangFromNhomChucNang method.
		/// </summary>
		GetByMaChucNangFromNhomChucNang,
		/// <summary>
		/// Represents the GetByNhomQuyenQL method.
		/// </summary>
		GetByNhomQuyenQL
	}
	
	#endregion NhomQuyenSelectMethod

	#region NhomQuyenFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomQuyen"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomQuyenFilter : SqlFilter<NhomQuyenColumn>
	{
	}
	
	#endregion NhomQuyenFilter

	#region NhomQuyenExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomQuyen"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomQuyenExpressionBuilder : SqlExpressionBuilder<NhomQuyenColumn>
	{
	}
	
	#endregion NhomQuyenExpressionBuilder	

	#region NhomQuyenProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;NhomQuyenChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="NhomQuyen"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomQuyenProperty : ChildEntityProperty<NhomQuyenChildEntityTypes>
	{
	}
	
	#endregion NhomQuyenProperty
}

