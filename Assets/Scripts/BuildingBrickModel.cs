using Normal.Realtime;
using Normal.Realtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RealtimeModel]
public partial class BuildingBrickModel
{
    [RealtimeProperty(1, true, true)]
    private bool _attached;

    // [RealtimeProperty(2, true, true)]
    // private string _matName;

    // [RealtimeProperty(3, true, true)]
    // private Vector3 _attachedPos;

    // [RealtimeProperty(4, true, true)] // Unused
    // private Quaternion _attachedRot;

    [RealtimeProperty(5, true, true)]
    private string _uuid;

    [RealtimeProperty(6, true, true)]
    private string _bricksAbove;

    [RealtimeProperty(7, true, true)]
    private string _bricksBelow;

    [RealtimeProperty(8, true, true)]
    private int _matId;

    [RealtimeProperty(9, true, true)]
    private int _color;

    [RealtimeProperty(10, true,true)]
    private bool _usingNewColors;
}

/* ----- Begin Normal Autogenerated Code ----- */
public partial class BuildingBrickModel : RealtimeModel {
    public bool attached {
        get {
            return _attachedProperty.value;
        }
        set {
            if (_attachedProperty.value == value) return;
            _attachedProperty.value = value;
            InvalidateReliableLength();
            FireAttachedDidChange(value);
        }
    }
    
    public string uuid {
        get {
            return _uuidProperty.value;
        }
        set {
            if (_uuidProperty.value == value) return;
            _uuidProperty.value = value;
            InvalidateReliableLength();
            FireUuidDidChange(value);
        }
    }
    
    public string bricksAbove {
        get {
            return _bricksAboveProperty.value;
        }
        set {
            if (_bricksAboveProperty.value == value) return;
            _bricksAboveProperty.value = value;
            InvalidateReliableLength();
            FireBricksAboveDidChange(value);
        }
    }
    
    public string bricksBelow {
        get {
            return _bricksBelowProperty.value;
        }
        set {
            if (_bricksBelowProperty.value == value) return;
            _bricksBelowProperty.value = value;
            InvalidateReliableLength();
            FireBricksBelowDidChange(value);
        }
    }
    
    public int matId {
        get {
            return _matIdProperty.value;
        }
        set {
            if (_matIdProperty.value == value) return;
            _matIdProperty.value = value;
            InvalidateReliableLength();
            FireMatIdDidChange(value);
        }
    }
    
    public int color {
        get {
            return _colorProperty.value;
        }
        set {
            if (_colorProperty.value == value) return;
            _colorProperty.value = value;
            InvalidateReliableLength();
            FireColorDidChange(value);
        }
    }
    
    public bool usingNewColors {
        get {
            return _usingNewColorsProperty.value;
        }
        set {
            if (_usingNewColorsProperty.value == value) return;
            _usingNewColorsProperty.value = value;
            InvalidateReliableLength();
            FireUsingNewColorsDidChange(value);
        }
    }
    
    public delegate void PropertyChangedHandler<in T>(BuildingBrickModel model, T value);
    public event PropertyChangedHandler<bool> attachedDidChange;
    public event PropertyChangedHandler<string> uuidDidChange;
    public event PropertyChangedHandler<string> bricksAboveDidChange;
    public event PropertyChangedHandler<string> bricksBelowDidChange;
    public event PropertyChangedHandler<int> matIdDidChange;
    public event PropertyChangedHandler<int> colorDidChange;
    public event PropertyChangedHandler<bool> usingNewColorsDidChange;
    
    public enum PropertyID : uint {
        Attached = 1,
        Uuid = 5,
        BricksAbove = 6,
        BricksBelow = 7,
        MatId = 8,
        Color = 9,
        UsingNewColors = 10,
    }
    
    #region Properties
    
    private ReliableProperty<bool> _attachedProperty;
    
    private ReliableProperty<string> _uuidProperty;
    
    private ReliableProperty<string> _bricksAboveProperty;
    
    private ReliableProperty<string> _bricksBelowProperty;
    
    private ReliableProperty<int> _matIdProperty;
    
    private ReliableProperty<int> _colorProperty;
    
    private ReliableProperty<bool> _usingNewColorsProperty;
    
    #endregion
    
    public BuildingBrickModel() : base(null) {
        _attachedProperty = new ReliableProperty<bool>(1, _attached);
        _uuidProperty = new ReliableProperty<string>(5, _uuid);
        _bricksAboveProperty = new ReliableProperty<string>(6, _bricksAbove);
        _bricksBelowProperty = new ReliableProperty<string>(7, _bricksBelow);
        _matIdProperty = new ReliableProperty<int>(8, _matId);
        _colorProperty = new ReliableProperty<int>(9, _color);
        _usingNewColorsProperty = new ReliableProperty<bool>(10, _usingNewColors);
    }
    
    protected override void OnParentReplaced(RealtimeModel previousParent, RealtimeModel currentParent) {
        _attachedProperty.UnsubscribeCallback();
        _uuidProperty.UnsubscribeCallback();
        _bricksAboveProperty.UnsubscribeCallback();
        _bricksBelowProperty.UnsubscribeCallback();
        _matIdProperty.UnsubscribeCallback();
        _colorProperty.UnsubscribeCallback();
        _usingNewColorsProperty.UnsubscribeCallback();
    }
    
    private void FireAttachedDidChange(bool value) {
        try {
            attachedDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireUuidDidChange(string value) {
        try {
            uuidDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireBricksAboveDidChange(string value) {
        try {
            bricksAboveDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireBricksBelowDidChange(string value) {
        try {
            bricksBelowDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireMatIdDidChange(int value) {
        try {
            matIdDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireColorDidChange(int value) {
        try {
            colorDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireUsingNewColorsDidChange(bool value) {
        try {
            usingNewColorsDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    protected override int WriteLength(StreamContext context) {
        var length = 0;
        length += _attachedProperty.WriteLength(context);
        length += _uuidProperty.WriteLength(context);
        length += _bricksAboveProperty.WriteLength(context);
        length += _bricksBelowProperty.WriteLength(context);
        length += _matIdProperty.WriteLength(context);
        length += _colorProperty.WriteLength(context);
        length += _usingNewColorsProperty.WriteLength(context);
        return length;
    }
    
    protected override void Write(WriteStream stream, StreamContext context) {
        var writes = false;
        writes |= _attachedProperty.Write(stream, context);
        writes |= _uuidProperty.Write(stream, context);
        writes |= _bricksAboveProperty.Write(stream, context);
        writes |= _bricksBelowProperty.Write(stream, context);
        writes |= _matIdProperty.Write(stream, context);
        writes |= _colorProperty.Write(stream, context);
        writes |= _usingNewColorsProperty.Write(stream, context);
        if (writes) InvalidateContextLength(context);
    }
    
    protected override void Read(ReadStream stream, StreamContext context) {
        var anyPropertiesChanged = false;
        while (stream.ReadNextPropertyID(out uint propertyID)) {
            var changed = false;
            switch (propertyID) {
                case (uint) PropertyID.Attached: {
                    changed = _attachedProperty.Read(stream, context);
                    if (changed) FireAttachedDidChange(attached);
                    break;
                }
                case (uint) PropertyID.Uuid: {
                    changed = _uuidProperty.Read(stream, context);
                    if (changed) FireUuidDidChange(uuid);
                    break;
                }
                case (uint) PropertyID.BricksAbove: {
                    changed = _bricksAboveProperty.Read(stream, context);
                    if (changed) FireBricksAboveDidChange(bricksAbove);
                    break;
                }
                case (uint) PropertyID.BricksBelow: {
                    changed = _bricksBelowProperty.Read(stream, context);
                    if (changed) FireBricksBelowDidChange(bricksBelow);
                    break;
                }
                case (uint) PropertyID.MatId: {
                    changed = _matIdProperty.Read(stream, context);
                    if (changed) FireMatIdDidChange(matId);
                    break;
                }
                case (uint) PropertyID.Color: {
                    changed = _colorProperty.Read(stream, context);
                    if (changed) FireColorDidChange(color);
                    break;
                }
                case (uint) PropertyID.UsingNewColors: {
                    changed = _usingNewColorsProperty.Read(stream, context);
                    if (changed) FireUsingNewColorsDidChange(usingNewColors);
                    break;
                }
                default: {
                    stream.SkipProperty();
                    break;
                }
            }
            anyPropertiesChanged |= changed;
        }
        if (anyPropertiesChanged) {
            UpdateBackingFields();
        }
    }
    
    private void UpdateBackingFields() {
        _attached = attached;
        _uuid = uuid;
        _bricksAbove = bricksAbove;
        _bricksBelow = bricksBelow;
        _matId = matId;
        _color = color;
        _usingNewColors = usingNewColors;
    }
    
}
/* ----- End Normal Autogenerated Code ----- */
