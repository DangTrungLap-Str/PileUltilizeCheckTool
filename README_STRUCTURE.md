# PileUtilizeCheckTool - Excel Add-In (Excel-DNA) Structure

## ✅ Cấu trúc dự án đã được cập nhật

### Thay đổi chính:

1. **Đổi tên project**: `ClassLibrary1` → `PileUtilizeCheck.ExcelAddIn`
2. **Đổi tên file DNA**: `PileUtilize.dna` → `PileUtilizeCheck.ExcelAddIn.dna`
3. **Reorganized folders**:
   - `AddIn/` - Chứa các UDF (User Defined Functions)
   - `Ribbon/` - Chứa Ribbon UI handlers

### Cấu trúc thư mục hiện tại:

```
PileUltilizeCheckTool/
├── PileUtilizeCheck.ExcelAddIn/          ← Excel-DNA Add-In Project
│   ├── AddIn/
│   │   └── Functions.vb                  ← UDF Functions
│   ├── Ribbon/
│   │   └── RibbonUI.vb                   ← Ribbon UI Handlers
│   ├── My Project/
│   ├── Properties/
│   ├── PileUtilizeCheck.ExcelAddIn.dna   ← DNA Config
│   ├── PileUtilizeCheck.ExcelAddIn.vbproj
│   └── packages.config
│
├── PileUtilizeCheck.Application/         ← Business Logic
├── PileUtilizeCheck.Geometry/            ← Geometry Calculations
├── PileUtilizeCheck.Infrastructure/      ← Infrastructure Layer
├── PileUtilizeCheck.Shared/              ← Shared Utilities
│
├── PileUtilizeCheck.App/                 ← [DEPRECATED - Remove if not needed]
└── PileUtilizeCheck.sln
```

## 🚀 Hướng dẫn sử dụng

### 1. Set startup project
- Chuột phải trên `PileUtilizeCheck.ExcelAddIn` → **Set as Startup Project**

### 2. Build solution
```
Build → Build Solution (hoặc Ctrl+Shift+B)
```
Output: 
- `PileUtilizeCheck.ExcelAddIn.xll` (64-bit)
- `PileUtilizeCheck.ExcelAddIn.xll` (32-bit)

### 3. Debug in Excel
- Nhấn F5 hoặc Debug → Start Debugging
- Excel sẽ mở với Add-In được load
- Sử dụng các UDF trong Functions.vb
- Ribbon tab "Pile Utilize" sẽ hiển thị

### 4. Thêm logic từ các project khác
Thêm Project References vào `PileUtilizeCheck.ExcelAddIn.vbproj`:
```xml
<ItemGroup>
  <ProjectReference Include="..\PileUtilizeCheck.Application\PileUtilizeCheck.Application.vbproj" />
  <ProjectReference Include="..\PileUtilizeCheck.Geometry\PileUtilizeCheck.Geometry.vbproj" />
  <ProjectReference Include="..\PileUtilizeCheck.Infrastructure\PileUtilizeCheck.Infrastructure.vbproj" />
  <ProjectReference Include="..\PileUtilizeCheck.Shared\PileUtilizeCheck.Shared.vbproj" />
</ItemGroup>
```

## 📝 Các file quan trọng

| File | Mục đích |
|------|----------|
| `PileUtilizeCheck.ExcelAddIn.dna` | Cấu hình Excel-DNA (Ribbon, External Libraries) |
| `AddIn/Functions.vb` | Chứa các UDF (=TESTFUNCTIONNAME(args)) |
| `Ribbon/RibbonUI.vb` | Handlers cho Ribbon buttons |
| `packages.config` | NuGet dependencies |

## 🔧 Để xóa project cũ (PileUtilizeCheck.App)

Nếu không cần nữa:
1. Chuột phải trên `PileUtilizeCheck.App` → **Remove**
2. Xóa thư mục `PileUtilizeCheck.App` từ File Explorer
3. Commit changes

## ✨ Tiếp theo

1. **Thêm logic từ Application, Geometry, etc.**
2. **Thêm more UDF functions** vào `AddIn/Functions.vb`
3. **Customize Ribbon UI** trong `Ribbon/RibbonUI.vb`
4. **Test trong Excel** - F5 để debug
