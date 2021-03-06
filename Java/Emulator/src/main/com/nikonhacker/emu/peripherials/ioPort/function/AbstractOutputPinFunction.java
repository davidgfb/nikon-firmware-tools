package com.nikonhacker.emu.peripherials.ioPort.function;

public abstract class AbstractOutputPinFunction implements PinFunction {

    protected String componentName;
    protected boolean logPinMessages = true;

    protected AbstractOutputPinFunction(String componentName) {
        this.componentName = componentName;
    }

    public void setLogPinMessages(boolean logPinMessages) {
        this.logPinMessages = logPinMessages;
    }

    /**
     * Delegates to that function the responsibility to provide an output.
     * The default output value (set by the CPU using setOutputValue) is passed in case the function wants to return it
     *
     * @param defaultOutputValue
     * @return
     */
    public abstract Integer getValue(Integer defaultOutputValue);
}
